' 4Play: Classic Connect 4 game
' Copyright (c) Samuel Gomes, 2021

' This class implements the AI player using the Minimax solver

Public Class AIPlayer
	' AI Debug messages
	Public Event ProcessNote(Note As String)

	' This will give us the best move for the "next" player per the game board
	' So we could also use this to generate hints for the opponent
	Public Function Think(ByRef GB As GameBoard) As Byte
		' Sanity checks
		Debug.Assert(GB.IsGameDraw() = False And GB.IsWinner() = GameBoard.EmptyCell)

		Dim move As Byte
		' First move if < 2 moves on the board
		If GB.GetTotalMoves < 2 Then
			move = GB.MaxX \ CByte(2)
			RaiseEvent ProcessNote("First move " & (move + 1))
			Return move
		End If

		' Set best score to the lowest possible
		Dim bestScore = Integer.MinValue
		Dim score As Integer
		' This is the player we are evaluating for
		Dim player = GB.GetNextPlayer()

		' Now go through the available moves and find the best score and best position
		For x As Byte = 0 To GB.MaxX
			' Play a move
			If GB.PlayMove(x) Then
				' Find the score for the move. Note we send the original player we are thinking for from GB
				score = Minimax(10, Integer.MinValue, Integer.MaxValue, False, player, GB)
				' Restore the board and to try next position
				GB.UndoMove()

				' If score if better than the last then save score and position
				If score >= bestScore Then
					bestScore = score
					move = x
				End If

				RaiseEvent ProcessNote("Score of " & (x + 1) & " = " & score)
			End If
		Next

		RaiseEvent ProcessNote("Move " & (move + 1))

		' Return the best move
		Return move
	End Function

	' AI Minimax logic
	Private Function Minimax(Depth As Byte, Alpha As Integer, Beta As Integer, IsMaximizing As Boolean, Player As SByte, ByRef GB As GameBoard) As Integer
		' Check if someone won. We always do this first
		Dim winner = GB.IsWinner()
		If winner <> GameBoard.EmptyCell Then
			' We also return larger numbers depending on the depth
			Return CInt(IIf(winner = Player, Short.MaxValue, Short.MinValue)) * (Depth + 1)
		End If

		' We return a zero if the game is a draw
		If GB.IsGameDraw() Then
			' Here value is already zero
			Return 0
		End If

		If Depth = 0 Then
			Return CInt(IIf(GB.CountConnect3(Player) > GB.CountConnect3(-Player), SByte.MaxValue, SByte.MinValue))
		End If

		Dim score, bestScore As Integer
		Dim x As Byte

		'RaiseEvent ProcessNote("Current depth: " & Depth)

		If IsMaximizing Then
			bestScore = Integer.MinValue
			For x = 0 To GB.MaxX
				If GB.PlayMove(x) Then
					score = Minimax(Depth - CByte(1), Alpha, Beta, False, Player, GB)
					bestScore = Math.Max(bestScore, score)
					' Restore the game Board
					GB.UndoMove()
					Alpha = Math.Max(Alpha, score)
					If Beta <= Alpha Then
						Exit For
					End If
				End If
			Next
		Else
			bestScore = Integer.MaxValue
			For x = 0 To GB.MaxX
				If GB.PlayMove(x) Then
					score = Minimax(Depth - CByte(1), Alpha, Beta, True, Player, GB)
					bestScore = Math.Min(bestScore, score)
					' Restore the game Board
					GB.UndoMove()
					Beta = Math.Min(Beta, score)
					If Beta <= Alpha Then
						Exit For
					End If
				End If
			Next
		End If

		Application.DoEvents()

		Return bestScore
	End Function
End Class

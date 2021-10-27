' 4Play: Classic Connect 4 game
' Copyright (c) Samuel Gomes, 2021

' This class implements the AI player using the Minimax solver with alpha-beta pruning
' See here: https://towardsdatascience.com/how-a-chess-playing-computer-thinks-about-its-next-move-8f028bd0e7b1

Public Class AIPlayer
	Public Thinking As Boolean = False                      ' Flag that is set when the AI is evaluating the board

	' Comments while thinking
	Public Event ProcessNote(Note As String)

	' Class constructor
	Public Sub New()
		' Seed the randomizer
		Randomize()
	End Sub

	' Computer AI method
	Public Function Think(ByRef C4Board As GameBoard) As Byte
		Dim x As Byte, move As Byte
		Dim BestScore, score As Long

		Debug.Assert(C4Board.IsGameDraw() = False)

		' Set thiking flag to true
		Thinking = True
		RaiseEvent ProcessNote("Thinking...")

		' Make a copy of the game Board
		Dim TmpBoard As GameBoard = CType(C4Board.Clone(), GameBoard)

		' Random move if < 4 moves on the board
		If C4Board.GetTotalMoves() < 3 Then
			Do
				move = CByte(CInt(Rnd() * CInt(C4Board.MaxX)))
				If C4Board.PlayMove(CByte(move)) Then
					' Restore the game Board
					C4Board = CType(TmpBoard.Clone(), GameBoard)
					RaiseEvent ProcessNote("Random move " & (move + 1))

					Thinking = False

					Return move
				End If
			Loop
		End If

		BestScore = Long.MinValue

		For x = 0 To C4Board.MaxX
			' We successfully played
			If C4Board.PlayMove(x) Then
				score = Minimax(0, Long.MinValue, Long.MaxValue, False, C4Board)
				' Restore the board and try next position
				C4Board = CType(TmpBoard.Clone(), GameBoard)
				If (score > BestScore) Then
					BestScore = score
					move = x
				End If
				RaiseEvent ProcessNote((x + 1) & " has score a of " & score)
			End If
		Next

		RaiseEvent ProcessNote("Move " & (move + 1) & " with score " & BestScore)

		' Set thinking flag to false
		Thinking = False

		Return move
	End Function

	' AI Minimax logic
	Private Function Minimax(Depth As Integer, Alpha As Long, Beta As Long, IsMaximizing As Boolean, ByRef C4Board As GameBoard) As Long
		Dim value As Long
		Dim x As Byte

		' Return the winner if someone won
		If C4Board.IsWinner() Then
			' Note the PlayMove function will always switch the player, so we always return the opponent (who actually made the move)
			Return C4Board.GetOpponent()
		End If

		' Leave if the game is a draw or we have reached the maximum depth
		If C4Board.IsGameDraw() Or Depth > 9 Then
			Return 0
		End If

		' Make a copy of the game Board
		Dim TmpBoard As GameBoard = CType(C4Board.Clone(), GameBoard)

		If IsMaximizing Then
			value = Long.MinValue
			For x = 0 To C4Board.MaxX
				If C4Board.PlayMove(x) Then
					value = Math.Max(value, Minimax(Depth + 1, Alpha, Beta, False, C4Board))
					' Restore the game Board
					C4Board = CType(TmpBoard.Clone(), GameBoard)
					Alpha = Math.Max(Alpha, value)
					If Alpha >= Beta Then
						Exit For
					End If
				End If
			Next
		Else
			value = Long.MaxValue
			For x = 0 To C4Board.MaxX
				If C4Board.PlayMove(x) Then
					value = Math.Min(value, Minimax(Depth + 1, Alpha, Beta, True, C4Board))
					' Restore the game Board
					C4Board = CType(TmpBoard.Clone(), GameBoard)
					Beta = Math.Min(Beta, value)
					If Beta <= Alpha Then
						Exit For
					End If
				End If
			Next
		End If

		Application.DoEvents()

		Return value
	End Function
End Class

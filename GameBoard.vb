' 4Play: Classic Connect 4 game
' Copyright (c) Samuel Gomes, 2021

' This class implements the game board and legal play logic

Public Class Game
	Public Event ProcessNote(Note As String)                    ' solver debug messages

	Public Enum Player As SByte
		RedWinner = -2
		Red = -1
		None = 0
		Yellow = 1
		YellowWinner = 2
	End Enum

	Public ReadOnly Board(,) As Player                          ' the main game board (0 - 6) x (0 - 5) = 7 x 6 - for Connect Four
	Public ReadOnly MaxX As Byte                                ' maximum number of columns
	Public ReadOnly MaxY As Byte                                ' maximum number of rows
	Private NextPlayer As Player                                ' next player. Note this player has not played yet!
	Private ReadOnly Moves(0) As Byte                           ' number of moves in a column
	Private TotalMoves As UShort                                ' total moves on the board
	Private ReadOnly MoveStack As Stack                         ' move stack

	' Constructor - sets the board size
	Public Sub New(mx As Byte, my As Byte)
		' Set the board size
		MaxX = mx
		MaxY = my
		' Allocate memory based on board size
		ReDim Board(MaxX, MaxY)
		ReDim Moves(MaxX)
		MoveStack = New Stack
		' Player 1 always goes first
		NextPlayer = Player.Red
		' Reset the board. Really not required
		'Reset()
	End Sub

	' Clears the game board
	Public Sub Reset()
		Dim x, y As Integer

		For x = 0 To MaxX
			For y = 0 To MaxY
				Board(x, y) = Player.None
			Next
			Moves(x) = 0
		Next

		TotalMoves = 0
		MoveStack.Clear()
	End Sub

	' Gets the next player (who has not played yet!)
	Public Function GetNextPlayer() As Player
		Return NextPlayer
	End Function

	' Returns the number of moves played
	Public Function GetTotalMoves() As UShort
		Return TotalMoves
	End Function

	' Returns the total number of moves in a particular column
	Public Function GetTotalMovesInColumn(x As Byte) As UShort
		Debug.Assert(x <= MaxX)

		Return Moves(x)
	End Function

	' Is a game in progress?
	Public Function HasGameStarted() As Boolean
		Return TotalMoves > 0
	End Function

	' Do we have a draw game?
	Public Function IsGameDraw() As Boolean
		Return TotalMoves >= ((MaxX + 1) * (MaxY + 1))
	End Function

	' Puts the move in the game board by the current player if allowed
	Public Function PlayMove(x As Byte) As Boolean
		Debug.Assert(x <= MaxX)

		For y As Byte = 0 To MaxY
			If Board(x, y) = Player.None Then
				' Put the checker in the column
				Board(x, y) = NextPlayer

				' Save this move
				MoveStack.Push(New Point(x, y))

				' Increment total moves and move in the column
				Moves(x) += CByte(1)
				TotalMoves += 1US

				' Switch the player
				NextPlayer = CType(-NextPlayer, Player)

				Return True
			End If
		Next

		Return False
	End Function

	' Undo the last move
	Public Function UndoMove() As Boolean
		' Is game board is not empty
		If TotalMoves > 0 Then
			' Remove the last move
			Dim LastMove As Point = CType(MoveStack.Pop(), Point)
			Board(LastMove.X, LastMove.Y) = Player.None

			' Decrement total moves and move in the column
			Moves(LastMove.X) -= CByte(1)
			TotalMoves -= 1US

			' Switch the player
			NextPlayer = CType(-NextPlayer, Player)

			Return True
		End If

		Return False
	End Function

	' Determines if we have a winner and return the player, else zero
	Public Function GetWinner(Optional mark As Boolean = False) As Player
		Dim x, y As Integer
		Dim pChecker, wChecker As Player

		' Check vertically (|)
		For x = 0 To MaxX
			For y = 0 To MaxY - CByte(3)
				If Math.Abs(Board(x, y) + Board(x, y + 1) + Board(x, y + 2) + Board(x, y + 3)) = 4 Then
					pChecker = Board(x, y)

					If mark Then
						wChecker = CType(pChecker * 2, Player)

						Board(x, y) = wChecker
						Board(x, y + 1) = wChecker
						Board(x, y + 2) = wChecker
						Board(x, y + 3) = wChecker
					End If

					Return pChecker
				End If
			Next
		Next

		' Check horizontally (-)
		For y = 0 To MaxY
			For x = 0 To MaxX - CByte(3)
				If Math.Abs(Board(x, y) + Board(x + 1, y) + Board(x + 2, y) + Board(x + 3, y)) = 4 Then
					pChecker = Board(x, y)

					If mark Then
						wChecker = CType(pChecker * 2, Player)

						Board(x, y) = wChecker
						Board(x + 1, y) = wChecker
						Board(x + 2, y) = wChecker
						Board(x + 3, y) = wChecker
					End If

					Return pChecker
				End If
			Next
		Next

		' Check diagonally (/)
		For y = 0 To MaxY - CByte(3)
			For x = 0 To MaxX - CByte(3)
				If Math.Abs(Board(x, y) + Board(x + 1, y + 1) + Board(x + 2, y + 2) + Board(x + 3, y + 3)) = 4 Then
					pChecker = Board(x, y)

					If mark Then
						wChecker = CType(pChecker * 2, Player)

						Board(x, y) = wChecker
						Board(x + 1, y + 1) = wChecker
						Board(x + 2, y + 2) = wChecker
						Board(x + 3, y + 3) = wChecker
					End If

					Return pChecker
				End If
			Next
		Next

		' Check diagonally (\)
		For y = 0 To MaxY - CByte(3)
			For x = MaxX To 3 Step -1
				If Math.Abs(Board(x, y) + Board(x - 1, y + 1) + Board(x - 2, y + 2) + Board(x - 3, y + 3)) = 4 Then
					pChecker = Board(x, y)

					If mark Then
						wChecker = CType(pChecker * 2, Player)

						Board(x, y) = wChecker
						Board(x - 1, y + 1) = wChecker
						Board(x - 2, y + 2) = wChecker
						Board(x - 3, y + 3) = wChecker
					End If

					Return pChecker
				End If
			Next
		Next

		' No winner yet
		Return Player.None
	End Function

	' Determines how many connect 3 we have
	Public Function CountConnect3(Player As SByte) As Integer
		Dim x, y, c As Integer

		' Check vertically (|)
		For x = 0 To MaxX
			For y = 0 To MaxY - CByte(2)
				If Math.Abs(Board(x, y) + Board(x, y + 1) + Board(x, y + 2)) = 3 Then
					If Player = Board(x, y) Then c += 1
				End If
			Next
		Next

		' Check horizontally (-)
		For y = 0 To MaxY
			For x = 0 To MaxX - CByte(2)
				If Math.Abs(Board(x, y) + Board(x + 1, y) + Board(x + 2, y)) = 3 Then
					If Player = Board(x, y) Then c += 1
				End If
			Next
		Next

		' Check diagonally (/)
		For y = 0 To MaxY - CByte(2)
			For x = 0 To MaxX - CByte(2)
				If Math.Abs(Board(x, y) + Board(x + 1, y + 1) + Board(x + 2, y + 2)) = 3 Then
					If Player = Board(x, y) Then c += 1
				End If
			Next
		Next

		' Check diagonally (\)
		For y = 0 To MaxY - CByte(2)
			For x = MaxX To 2 Step -1
				If Math.Abs(Board(x, y) + Board(x - 1, y + 1) + Board(x - 2, y + 2)) = 3 Then
					If Player = Board(x, y) Then c += 1
				End If
			Next
		Next

		Return c
	End Function

	' This will give us the best move for the "next" player per the game board
	' So we could also use this to generate hints for the opponent
	Public Function Think() As Byte
		' Sanity checks
		Debug.Assert(IsGameDraw() = False And GetWinner() = Game.Player.None)

		Dim move As Byte
		' First move if < 2 moves on the board
		If GetTotalMoves() < 2 Then
			move = MaxX \ CByte(2)
			RaiseEvent ProcessNote("First move " & (move + 1))
			Return move
		End If

		' Set best score to the lowest possible
		Dim bestScore = Integer.MinValue
		Dim score As Integer
		' This is the player we are evaluating for
		Dim player = GetNextPlayer()

		' Now go through the available moves and find the best score and best Board
		For x As Byte = 0 To MaxX
			' Play a move
			If PlayMove(x) Then
				' Find the score for the move. Note we send the original player we are thinking for from GB
				score = Minimax(10, Integer.MinValue, Integer.MaxValue, False, player)
				' Restore the board and to try next Board
				UndoMove()

				' If score if better than the last then save score and Board
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

	' AI Minimax logic that implements the AI player using the Minimax solver
	Private Function Minimax(Depth As Byte, Alpha As Integer, Beta As Integer, IsMaximizing As Boolean, Player As Player) As Integer
		' Check if someone won. We always do this first
		Dim winner = GetWinner()
		If winner <> Player.None Then
			' We also return larger numbers depending on the depth
			Return CInt(IIf(winner = Player, Short.MaxValue, Short.MinValue)) * (Depth + 1)
		End If

		' We return a zero if the game is a draw
		If IsGameDraw() Then
			' Here value is already zero
			Return 0
		End If

		If Depth = 0 Then
			Return CInt(IIf(CountConnect3(Player) > CountConnect3(-Player), SByte.MaxValue, SByte.MinValue))
		End If

		Dim score, bestScore As Integer
		Dim x As Byte

		'RaiseEvent ProcessNote("Current depth: " & Depth)

		If IsMaximizing Then
			bestScore = Integer.MinValue
			For x = 0 To MaxX
				If PlayMove(x) Then
					score = Minimax(Depth - CByte(1), Alpha, Beta, False, Player)
					bestScore = Math.Max(bestScore, score)
					' Restore the game Board
					UndoMove()
					Alpha = Math.Max(Alpha, score)
					If Beta <= Alpha Then
						Exit For
					End If
				End If
			Next
		Else
			bestScore = Integer.MaxValue
			For x = 0 To MaxX
				If PlayMove(x) Then
					score = Minimax(Depth - CByte(1), Alpha, Beta, True, Player)
					bestScore = Math.Min(bestScore, score)
					' Restore the game Board
					UndoMove()
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

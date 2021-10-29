' 4Play: Classic Connect 4 game
' Copyright (c) Samuel Gomes, 2021

' This class implements the game board and legal play logic

Public Class GameBoard
	Public ReadOnly Position(0, 0) As SByte                     ' The main game board (0 - 6) x (0 - 5) = 7 x 6 - for Connect Four
	Public Const Player1Checker As SByte = -1                   ' Player 1 checker
	Public Const Player2Checker As SByte = 1                    ' Player 2 checker
	Public Const Player1WinningChecker As SByte = -2            ' Player 1 winning checker
	Public Const Player2WinningChecker As SByte = 2             ' Player 2 winning checker
	Public Const EmptyCell As SByte = 0                         ' Empty cell marker
	Public ReadOnly MaxX As Byte                                ' Maximum number of columns
	Public ReadOnly MaxY As Byte                                ' Maximum number of rows
	Private NextPlayer As SByte                                 ' Next player. Note this player has not played yet!
	Private ReadOnly Moves(0) As Byte                           ' Number of moves in a column
	Private TotalMoves As UShort                                ' Total moves on the board
	Private ReadOnly MoveStack As Stack                         ' Previous moves

	' Constructor - sets the board size
	Public Sub New(x As Byte, y As Byte)
		' Set the board size
		MaxX = x
		MaxY = y
		' Allocate memory based on board size
		ReDim Position(MaxX, MaxY)
		ReDim Moves(MaxX)
		MoveStack = New Stack
		' Player 1 always goes first
		NextPlayer = Player1Checker
		' Reset the board. Really not required
		'Reset()
	End Sub

	' Clears the game board
	Public Sub Reset()
		Dim x, y As Integer

		For x = 0 To MaxX
			For y = 0 To MaxY
				Position(x, y) = EmptyCell
			Next
			Moves(x) = 0
		Next

		TotalMoves = 0
		MoveStack.Clear()
	End Sub

	' Gets the next player (who has not played yet!)
	Public Function GetNextPlayer() As SByte
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
			If Position(x, y) = EmptyCell Then
				' Put the checker in the column
				Position(x, y) = NextPlayer

				' Save this move
				MoveStack.Push(New Point(x, y))

				' Increment total moves and move in the column
				Moves(x) += CByte(1)
				TotalMoves += 1US

				' Switch the player
				NextPlayer = -NextPlayer

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
			Position(LastMove.X, LastMove.Y) = EmptyCell

			' Decrement total moves and move in the column
			Moves(LastMove.X) -= CByte(1)
			TotalMoves -= 1US

			' Switch the player
			NextPlayer = -NextPlayer

			Return True
		End If

		Return False
	End Function

	' Determines if we have a winner and return the player, else zero
	Public Function IsWinner(Optional mark As Boolean = False) As SByte
		Dim x, y As Integer
		Dim pChecker, wChecker As SByte

		' Check vertically (|)
		For x = 0 To MaxX
			For y = 0 To MaxY - CByte(3)
				If Math.Abs(Position(x, y) + Position(x, y + 1) + Position(x, y + 2) + Position(x, y + 3)) = 4 Then
					pChecker = Position(x, y)

					If mark Then
						wChecker = pChecker * CSByte(2)

						Position(x, y) = wChecker
						Position(x, y + 1) = wChecker
						Position(x, y + 2) = wChecker
						Position(x, y + 3) = wChecker
					End If

					Return pChecker
				End If
			Next
		Next

		' Check horizontally (-)
		For y = 0 To MaxY
			For x = 0 To MaxX - CByte(3)
				If Math.Abs(Position(x, y) + Position(x + 1, y) + Position(x + 2, y) + Position(x + 3, y)) = 4 Then
					pChecker = Position(x, y)

					If mark Then
						wChecker = pChecker * CSByte(2)

						Position(x, y) = wChecker
						Position(x + 1, y) = wChecker
						Position(x + 2, y) = wChecker
						Position(x + 3, y) = wChecker
					End If

					Return pChecker
				End If
			Next
		Next

		' Check diagonally (/)
		For y = 0 To MaxY - CByte(3)
			For x = 0 To MaxX - CByte(3)
				If Math.Abs(Position(x, y) + Position(x + 1, y + 1) + Position(x + 2, y + 2) + Position(x + 3, y + 3)) = 4 Then
					pChecker = Position(x, y)

					If mark Then
						wChecker = pChecker * CSByte(2)

						Position(x, y) = wChecker
						Position(x + 1, y + 1) = wChecker
						Position(x + 2, y + 2) = wChecker
						Position(x + 3, y + 3) = wChecker
					End If

					Return pChecker
				End If
			Next
		Next

		' Check diagonally (\)
		For y = 0 To MaxY - CByte(3)
			For x = MaxX To 3 Step -1
				If Math.Abs(Position(x, y) + Position(x - 1, y + 1) + Position(x - 2, y + 2) + Position(x - 3, y + 3)) = 4 Then
					pChecker = Position(x, y)

					If mark Then
						wChecker = pChecker * CSByte(2)

						Position(x, y) = wChecker
						Position(x - 1, y + 1) = wChecker
						Position(x - 2, y + 2) = wChecker
						Position(x - 3, y + 3) = wChecker
					End If

					Return pChecker
				End If
			Next
		Next

		' No winner yet
		Return EmptyCell
	End Function

	' Determines how many connect 3 we have
	Public Function CountConnect3(Player As SByte) As Integer
		Dim x, y, c As Integer

		' Check vertically (|)
		For x = 0 To MaxX
			For y = 0 To MaxY - CByte(2)
				If Math.Abs(Position(x, y) + Position(x, y + 1) + Position(x, y + 2)) = 3 Then
					If Player = Position(x, y) Then c += 1
				End If
			Next
		Next

		' Check horizontally (-)
		For y = 0 To MaxY
			For x = 0 To MaxX - CByte(2)
				If Math.Abs(Position(x, y) + Position(x + 1, y) + Position(x + 2, y)) = 3 Then
					If Player = Position(x, y) Then c += 1
				End If
			Next
		Next

		' Check diagonally (/)
		For y = 0 To MaxY - CByte(2)
			For x = 0 To MaxX - CByte(2)
				If Math.Abs(Position(x, y) + Position(x + 1, y + 1) + Position(x + 2, y + 2)) = 3 Then
					If Player = Position(x, y) Then c += 1
				End If
			Next
		Next

		' Check diagonally (\)
		For y = 0 To MaxY - CByte(2)
			For x = MaxX To 2 Step -1
				If Math.Abs(Position(x, y) + Position(x - 1, y + 1) + Position(x - 2, y + 2)) = 3 Then
					If Player = Position(x, y) Then c += 1
				End If
			Next
		Next

		Return c
	End Function
End Class

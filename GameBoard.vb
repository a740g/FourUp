' 4Play: Classic Connect 4 game
' Copyright (c) Samuel Gomes, 2021

' This class implements the game board and legal play logic

Public Class GameBoard
	Implements ICloneable

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

	' Constructor - sets the board size
	Public Sub New(x As Byte, y As Byte)
		' Set the board size
		MaxX = x
		MaxY = y
		' Allocate memory based on board size
		ReDim Position(MaxX, MaxY)
		ReDim Moves(MaxX)
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
	End Sub

	' Gets the next player (who has not played yet!)
	Public Function GetNextPlayer() As SByte
		Return NextPlayer
	End Function

	' Gets the last player (who played the last move provided the game has started)
	Public Function GetLastPlayer() As SByte
		' Find the opponent player
		Return -NextPlayer
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

	' Returns true if a move is allowed
	Private Function IsMoveAllowed(x As Byte, y As Byte) As Boolean
		Debug.Assert(x <= MaxX And y <= MaxY)

		If Position(x, y) = EmptyCell Then
			If y > 0 Then
				If Position(x, y - 1) = EmptyCell Then
					' There is nothing below!
					Return False
				End If

				Return True
			End If

			' Moves are always allowed at the base
			Return True
		End If

		' Place is already taken!
		Return False
	End Function

	' Puts the move in the game board by the current player if allowed
	Public Function PlayMove(x As Byte) As Boolean
		Debug.Assert(x <= MaxX)

		For y As Byte = 0 To MaxY
			If IsMoveAllowed(x, y) Then
				' Put the checker in the column
				Position(x, y) = NextPlayer

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

	' This creates a new copy of an object of GameBoard
	Public Function Clone() As Object Implements ICloneable.Clone
		Dim c As New GameBoard(MaxX, MaxY)

		Array.Copy(Position, c.Position, Position.Length)
		c.NextPlayer = NextPlayer
		Array.Copy(Moves, c.Moves, Moves.Length)
		c.TotalMoves = TotalMoves

		Return c
	End Function
End Class

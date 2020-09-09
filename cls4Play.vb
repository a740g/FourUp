' 4Play: Classic Connect 4 game against AI
' Copyright (c) Samuel Gomes, 2020

' This class defines the core game engine
' Currently this game uses the Minimax solver with alpha-beta pruning
' TODO: There are bugs to fix and we'll have to optimize the AI

Public Class Cls4Play
	' Some public constants
	Public Const Player1Chip As Integer = -1
	Public Const Player2Chip As Integer = 1
	Public Const Player1WinChip As Integer = -10
	Public Const Player2WinChip As Integer = 10
	Public Const EmptyCellChip As Integer = 0
	Public Const MaxX As Integer = 6
	Public Const MaxY As Integer = 5

	' Flag that is set when the AI is evaluating the board
	Public Thinking As Boolean = False
	' Current player
	Public Player As Integer = Player1Chip

	' The main game Board (0 - 6) x (0 - 5) = 7 x 6
	Private ReadOnly Board(MaxX, MaxY) As Integer

	' Comments while thinking
	Public Event ProcessNote(Note As String)

	' Class constructor
	Public Sub New()
		Randomize()
		RestartGame()
	End Sub

	' Clears the game Board
	Public Sub RestartGame()
		Dim x, y As Integer

		For y = 0 To MaxY
			For x = 0 To MaxX
				Board(x, y) = EmptyCellChip
			Next
		Next

		RaiseEvent ProcessNote("Ready!")
	End Sub

	' Find the opponent player
	Public Function Opponent(sPlayer As Integer) As Integer
		' Find the opponent player
		Return CInt(IIf(sPlayer = Player1Chip, Player2Chip, Player1Chip))
	End Function

	' Changes or switches between active players
	Public Sub SwitchPlayers()
		' Switch players
		Player = Opponent(Player)
	End Sub

	' Returns true if a move is allowed
	Public Function IsMoveAllowed(x As Integer, y As Integer) As Boolean
		If x < 0 Or y < 0 Or x > MaxX Or y > MaxY Then Return False

		If Board(x, y) = EmptyCellChip Then
			If y > 0 Then
				If Board(x, y - 1) = EmptyCellChip Then
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

	' Gets a move from a particular game Board position
	Public Function GetMove(x As Integer, y As Integer) As Integer
		Return Board(x, y)
	End Function

	' Puts the move in the game Board if allowed
	Public Function PlayMove(x As Integer, y As Integer, sPlayer As Integer) As Boolean
		If IsMoveAllowed(x, y) Then
			Board(x, y) = sPlayer
			Return True
		End If

		Return False
	End Function

	' Returns the total number of moves in the game Board
	Public Function GetTotalMoves() As Integer
		Dim x, y As Integer
		Dim iCount As Integer = 0

		For y = 0 To MaxY
			For x = 0 To MaxX
				If Board(x, y) <> EmptyCellChip Then iCount += 1
			Next
		Next

		Return iCount
	End Function

	' Returns the total number of moves in a particular game matix column
	Public Function GetTotalMovesInColumn(iColumn As Integer) As Integer
		Dim y As Integer
		Dim iCount As Integer = 0

		For y = 0 To MaxY
			If Board(iColumn, y) <> EmptyCellChip Then iCount += 1
		Next

		Return iCount
	End Function

	' Is a game in progress?
	Public Function IsGameStarted() As Boolean
		Return GetTotalMoves() > 0
	End Function

	' Do we have a draw game?
	Public Function IsGameDraw() As Boolean
		Return GetTotalMoves() >= ((MaxX + 1) * (MaxY + 1))
	End Function

	' Puts a chip in a particular column if allowed
	Public Function PutChipInColumn(iColumn As Integer, sPlayer As Integer) As Boolean
		Dim y As Integer

		For y = 0 To MaxY
			If PlayMove(iColumn, y, sPlayer) Then
				Return True
			End If
		Next

		Return False
	End Function

	' Determins if the given player is the winner
	Public Function IsWinner(MarkSpots As Boolean, sChip As Integer) As Boolean
		Dim WinChip As Integer
		Dim x, y As Integer

		' Set the appropriate winning chip
		WinChip = CInt(IIf(sChip = Player1Chip, Player1WinChip, Player2WinChip))

		' Check vertically
		For x = 0 To MaxX
			For y = 0 To MaxY - 3
				If (Board(x, y) + Board(x, y + 1) + Board(x, y + 2) + Board(x, y + 3)) = (sChip + sChip + sChip + sChip) Then
					If MarkSpots Then
						Board(x, y) = WinChip
						Board(x, y + 1) = WinChip
						Board(x, y + 2) = WinChip
						Board(x, y + 3) = WinChip
					End If

					Return True
				End If
			Next
		Next

		' Check horizontally
		For y = 0 To MaxY
			For x = 0 To MaxX - 3
				If (Board(x, y) + Board(x + 1, y) + Board(x + 2, y) + Board(x + 3, y)) = (sChip + sChip + sChip + sChip) Then
					If MarkSpots Then
						Board(x, y) = WinChip
						Board(x + 1, y) = WinChip
						Board(x + 2, y) = WinChip
						Board(x + 3, y) = WinChip
					End If

					Return True
				End If
			Next
		Next

		' Check diagonally (/)
		For y = 0 To MaxY - 3
			For x = 0 To MaxX - 3
				If (Board(x, y) + Board(x + 1, y + 1) + Board(x + 2, y + 2) + Board(x + 3, y + 3)) = (sChip + sChip + sChip + sChip) Then
					If MarkSpots Then
						Board(x, y) = WinChip
						Board(x + 1, y + 1) = WinChip
						Board(x + 2, y + 2) = WinChip
						Board(x + 3, y + 3) = WinChip
					End If

					Return True
				End If
			Next
		Next

		' Check diagonally (\)
		For y = 0 To MaxY - 3
			For x = MaxX To 3 Step -1
				If (Board(x, y) + Board(x - 1, y + 1) + Board(x - 2, y + 2) + Board(x - 3, y + 3)) = (sChip + sChip + sChip + sChip) Then
					If MarkSpots Then
						Board(x, y) = WinChip
						Board(x - 1, y + 1) = WinChip
						Board(x - 2, y + 2) = WinChip
						Board(x - 3, y + 3) = WinChip
					End If

					Return True
				End If
			Next
		Next

		' No winner yet
		Return False
	End Function

	' Computer AI method
	Public Function Think() As Integer
		Dim TmpBoard(MaxX, MaxY) As Integer
		Dim i As Integer, iB As Integer, iE As Integer, iStep As Integer
		Dim BestScore As Long
		Dim Score As Long
		Dim Move As Integer

		If IsGameDraw() Then Debug.Fail("Think: Game logic error!", "Think() called on a draw board!")

		' Set thiking flag to true
		Thinking = True
		RaiseEvent ProcessNote("Thinking...")

		' Make a copy of the game Board
		Array.Copy(Board, TmpBoard, Board.Length)

		iStep = If(CInt(Rnd() * 1.0!) = 0, -1, 1)
		If iStep = -1 Then
			iB = MaxX
			iE = 0
		Else
			iB = 0
			iE = MaxX
		End If

		BestScore = Long.MinValue

		For i = iB To iE Step iStep
			' We successfully played
			If PutChipInColumn(i, Player2Chip) Then
				Score = Minimax(0, Long.MinValue, Long.MaxValue, False)
				' Restore the board and try next position
				Array.Copy(TmpBoard, Board, Board.Length)
				If (Score > BestScore) Then
					BestScore = Score
					Move = i
				End If
				RaiseEvent ProcessNote((i + 1) & " has score a of " & Score)
			End If
		Next

		RaiseEvent ProcessNote("Move " & (Move + 1) & " with score " & BestScore)

		' Set thinking flag to false
		Thinking = False

		Return Move
	End Function

	Private Function Minimax(Depth As Integer, ByVal Alpha As Long, ByVal Beta As Long, IsMaximizing As Boolean) As Long
		Dim TmpBoard(MaxX, MaxY) As Integer
		Dim Value As Long
		Dim i As Integer

		If IsWinner(False, Player1Chip) Then
			Return Player1WinChip
		End If

		If IsWinner(False, Player2Chip) Then
			Return Player2WinChip
		End If

		If IsGameDraw() Or Depth > 9 Then
			Return 0
		End If

		' Make a copy of the game Board
		Array.Copy(Board, TmpBoard, Board.Length)

		If IsMaximizing Then
			Value = Long.MinValue
			For i = 0 To MaxX
				If PutChipInColumn(i, Player2Chip) Then
					Value = Math.Max(Value, Minimax(Depth + 1, Alpha, Beta, False))
					' Restore the game Board
					Array.Copy(TmpBoard, Board, Board.Length)
					Alpha = Math.Max(Alpha, Value)
					If Alpha >= Beta Then
						Exit For
					End If
				End If
			Next
		Else
			Value = Long.MaxValue
			For i = 0 To MaxX
				If PutChipInColumn(i, Player1Chip) Then
					Value = Math.Min(Value, Minimax(Depth + 1, Alpha, Beta, True))
					' Restore the game Board
					Array.Copy(TmpBoard, Board, Board.Length)
					Beta = Math.Min(Beta, Value)
					If Beta <= Alpha Then
						Exit For
					End If
				End If
			Next
		End If

		Application.DoEvents()

		Return Value
	End Function
End Class

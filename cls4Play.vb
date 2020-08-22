''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' 4Play: Classic Connect 4 against computer                  '
'                                                            '
' Copyright (c) Samuel Gomes, 1997-2020                      '
' All right reserved.                                        '
'                                                            '
' mailto: v_2samg@hotmail.com || gomes.samuel@gmail.com      '
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

' This class defines the core game engine
' Currently this games uses a "weak" solver
' Someday we should update this to use Minimax with alpha-beta pruning

Public Class Cls4Play
	' Some public constants
	Public Const Player1Chip As Integer = 1
	Public Const Player2Chip As Integer = -1
	Public Const Player1WinChip As Integer = 10
	Public Const Player2WinChip As Integer = -10
	Public Const EmptyCellChip As Integer = 0
	Public Const MaxX As Integer = 6
	Public Const MaxY As Integer = 5
	' The main game Board (0 - 6) x (0 - 5) = 7 x 6
	Private ReadOnly Board(MaxX, MaxY) As Integer
	' Current player
	Private Player As Integer = Player1Chip

	' Comments while thinking
	Public Event ProcessNote(Note As String)

	' Class constructor
	Public Sub New()
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

	' Returns true if a move is allowed
	Public Function IsMoveAllowed(x As Integer, y As Integer) As Boolean
		If x > MaxX Or y > MaxY Then Return False

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
	Public Function PlayMove(x As Integer, y As Integer, Optional sPlayer As Integer = EmptyCellChip) As Boolean
		If sPlayer = EmptyCellChip Then sPlayer = Player

		If IsMoveAllowed(x, y) Then
			Board(x, y) = sPlayer
			Return True
		End If

		Return False
	End Function

	' Find the opponent player
	Public Function Opponent(Optional sPlayer As Integer = EmptyCellChip) As Integer
		' Find the opponent player
		If sPlayer = EmptyCellChip Then sPlayer = Player
		Return CInt(IIf(sPlayer = Player1Chip, Player2Chip, Player1Chip))
	End Function

	' Changes or switches between active players
	Public Sub SwitchPlayers()
		' Switch players
		Player = Opponent()
	End Sub

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

	' Returns the total number of moves in a particular game matix row
	Public Function GetTotalMovesInRow(iRow As Integer) As Integer
		Dim y As Integer
		Dim iCount As Integer = 0

		For y = 0 To MaxY
			If Board(iRow, y) <> EmptyCellChip Then iCount += 1
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

	' Puts a chip in a particular row if allowed
	Public Function PutChipInRow(iRow As Integer, Optional sPlayer As Integer = EmptyCellChip) As Boolean
		Dim y As Integer

		For y = 0 To MaxY
			If PlayMove(iRow, y, sPlayer) Then
				Return True
			End If
		Next

		Return False
	End Function

	' Who is the current player? (set & get)
	Public Property CurrentPlayer() As Integer
		Get
			Return Player
		End Get

		Set(sValue As Integer)
			Player = CInt(IIf(sValue = Player1Chip, Player1Chip, Player2Chip))
		End Set
	End Property

	' Determins if the given player is the winner
	Public Function IsWinner(MarkSpots As Boolean, Optional sChip As Integer = EmptyCellChip) As Boolean
		Dim WinChip As Integer
		Dim x, y As Integer

		' If no parameter was passed check for previous player
		If sChip = EmptyCellChip Then
			sChip = CInt(IIf(Player = Player1Chip, Player2Chip, Player1Chip))
		End If

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
	Public Function Think(Optional sPlayer As Integer = EmptyCellChip, Optional Depth As Integer = 0) As Integer
		Dim sBoard(MaxX, MaxY) As Integer

		If Depth = 0 Then RaiseEvent ProcessNote("Thinking...")

		' Leave if there are no more places to think for
		If IsGameDraw() Then Return -MaxX - 1

		' Use default positions if less than 3 moves
		If GetTotalMoves() < 3 Then
			If Depth = 0 Then RaiseEvent ProcessNote("Opening move.")

			If Board(MaxX \ 2, 0) = EmptyCellChip Then
				Return MaxX \ 2
			ElseIf Board((MaxX \ 2) + 1, 0) = EmptyCellChip Then
				Return (MaxX \ 2) + 1
			ElseIf Board((MaxX \ 2) - 1, 0) = EmptyCellChip Then
				Return (MaxX \ 2) - 1
			End If
		End If

		' Determine the player
		If sPlayer = EmptyCellChip Then sPlayer = Player

		' Make a copy of the game Board
		Array.Copy(Board, sBoard, Board.Length)

		Dim i As Integer
		' Play a move and check if we "win" and they are not winning
		For i = 0 To MaxX
			' We successfully played
			If PutChipInRow(i, sPlayer) Then
				' Now check if we won
				If IsWinner(False, sPlayer) And Not IsWinner(False, Opponent(sPlayer)) Then
					' Restore the game Board and return the position
					Array.Copy(sBoard, Board, Board.Length)
					If Depth = 0 Then RaiseEvent ProcessNote("Found " & i + 1 & ".")
					Return i
				End If
				' Restore the board and try next position
				Array.Copy(sBoard, Board, Board.Length)
			End If
		Next

		' Recursive game logic starts here

		' Play some move
		For i = 0 To MaxX
			If PutChipInRow(i, sPlayer) Then Exit For
		Next

		' Recursively call think
		RaiseEvent ProcessNote("Depth " & Depth & ".")
		Application.DoEvents()

		i = Think(Opponent(sPlayer), Depth + 1)

		' Restore the board
		Array.Copy(sBoard, Board, Board.Length)

		If Depth = 0 Then RaiseEvent ProcessNote("Found " & i + 1 & ".")

		Return i
	End Function
End Class

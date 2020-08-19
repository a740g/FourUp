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
	Public Const Player1Chip As String = "X"
	Public Const Player2Chip As String = "O"
	Public Const Player1WinChip As String = "x"
	Public Const Player2WinChip As String = "o"
	Public Const EmptyCellChip As String = " "
	Public Const MaxX As Integer = 6
	Public Const MaxY As Integer = 5

	' The main game Board (0 - 6) x (0 - 5) = 7 x 6
	Private ReadOnly Board(MaxX, MaxY) As String
	' Current player
	Private Player As String = Player1Chip

	' Comments while thinking
	Public Event ProcessNote(ByVal Note As String)

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
	Public Function IsMoveAllowed(ByVal x As Integer, ByVal y As Integer) As Boolean
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
	Public Function GetMove(ByVal x As Integer, ByVal y As Integer) As String
		Return Board(x, y)
	End Function

	' Puts the move in the game Board if allowed
	Public Function PlayMove(ByVal x As Integer, ByVal y As Integer, Optional ByVal sPlayer As String = vbNullString) As Boolean
		If sPlayer = vbNullString Then sPlayer = Player

		If IsMoveAllowed(x, y) Then
			Board(x, y) = sPlayer
			Return True
		End If

		Return False
	End Function

	' Find the opponent player
	Public Function Opponent(Optional ByVal sPlayer As String = vbNullString) As String
		' Find the opponent player
		If sPlayer = vbNullString Then sPlayer = Player
		Return CStr(IIf(sPlayer = Player1Chip, Player2Chip, Player1Chip))
	End Function

	' Changes or switches between active players
	Public Sub SwitchPlayers()
		' Switch players
		Player = Opponent()
	End Sub

	' Returns the total number of moves in the game Board
	Public Function GetTotalMoves() As Integer
		Dim x, y As Integer
		Dim iCount As Integer

		For y = 0 To MaxY
			For x = 0 To MaxX
				If Board(x, y) <> EmptyCellChip Then iCount += 1
			Next
		Next

		Return iCount
	End Function

	' Returns the total number of moves in a particular game matix row
	Public Function GetTotalMovesInRow(ByVal iRow As Integer) As Integer
		Dim y, iCount As Integer

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
	Public Function PutChipInRow(ByVal iRow As Integer, Optional ByVal sPlayer As String = vbNullString) As Boolean
		Dim y As Integer

		For y = 0 To MaxY
			If PlayMove(iRow, y, sPlayer) Then
				Return True
			End If
		Next

		Return False
	End Function

	' Who is the current player? (set & get)
	Public Property CurrentPlayer() As String
		Get
			Return Player
		End Get

		Set(ByVal sValue As String)
			Player = CStr(IIf(sValue = Player1Chip, Player1Chip, Player2Chip))
		End Set
	End Property

	' Determins if the given player is the winner
	Public Function IsWinner(Optional ByVal sChip As String = vbNullString) As Boolean
		Dim WinChip As String
		Dim x, y As Integer

		' If no parameter was passed check for previous player
		If sChip = vbNullString Then
			sChip = CStr(IIf(Player = Player1Chip, Player2Chip, Player1Chip))
		End If

		' Set the appropriate winning chip
		WinChip = CStr(IIf(sChip = Player1Chip, Player1WinChip, Player2WinChip))

		' Check vertically
		For x = 0 To MaxX
			For y = 0 To MaxY - 3
				If (Board(x, y) & Board(x, y + 1) & Board(x, y + 2) & Board(x, y + 3)) = (sChip & sChip & sChip & sChip) Then
					Board(x, y) = WinChip
					Board(x, y + 1) = WinChip
					Board(x, y + 2) = WinChip
					Board(x, y + 3) = WinChip
					Return True
				End If
			Next
		Next

		' Check horizontally
		For y = 0 To MaxY
			For x = 0 To MaxX - 3
				If (Board(x, y) & Board(x + 1, y) & Board(x + 2, y) & Board(x + 3, y)) = (sChip & sChip & sChip & sChip) Then
					Board(x, y) = WinChip
					Board(x + 1, y) = WinChip
					Board(x + 2, y) = WinChip
					Board(x + 3, y) = WinChip
					Return True
				End If
			Next
		Next

		' Check diagonally (/)
		For y = 0 To MaxY - 3
			For x = 0 To MaxX - 3
				If (Board(x, y) & Board(x + 1, y + 1) & Board(x + 2, y + 2) & Board(x + 3, y + 3)) = (sChip & sChip & sChip & sChip) Then
					Board(x, y) = WinChip
					Board(x + 1, y + 1) = WinChip
					Board(x + 2, y + 2) = WinChip
					Board(x + 3, y + 3) = WinChip
					Return True
				End If
			Next
		Next

		' Check diagonally (\)
		For y = 0 To MaxY - 3
			For x = MaxX To 3 Step -1
				If (Board(x, y) & Board(x - 1, y + 1) & Board(x - 2, y + 2) & Board(x - 3, y + 3)) = (sChip & sChip & sChip & sChip) Then
					Board(x, y) = WinChip
					Board(x - 1, y + 1) = WinChip
					Board(x - 2, y + 2) = WinChip
					Board(x - 3, y + 3) = WinChip
					Return True
				End If
			Next
		Next

		' No winner yet
		Return False
	End Function

	' Searches for critical winning or loosing positions (AI helper)
	Private Function ComputerSearch(ByVal sChip As String) As Integer
		Dim x, y As Integer

		' Search vertically
		For x = 0 To MaxX
			For y = 0 To MaxY - 3
				If (Board(x, y) & Board(x, y + 1) & Board(x, y + 2) & Board(x, y + 3)) = (sChip & sChip & sChip & EmptyCellChip) Then
					If IsMoveAllowed(x, y + 3) Then
						Return x
					End If
				End If
			Next
		Next

		' Search horizontally
		For y = 0 To MaxY
			For x = 0 To MaxX - 3
				If (Board(x, y) & Board(x + 1, y) & Board(x + 2, y) & Board(x + 3, y)) = (sChip & sChip & sChip & EmptyCellChip) Then
					If IsMoveAllowed(x + 3, y) Then
						Return x + 3
					End If
				End If
				If (Board(x, y) & Board(x + 1, y) & Board(x + 2, y) & Board(x + 3, y)) = (sChip & sChip & EmptyCellChip & sChip) Then
					If IsMoveAllowed(x + 2, y) Then
						Return x + 2
					End If
				End If
				If (Board(x, y) & Board(x + 1, y) & Board(x + 2, y) & Board(x + 3, y)) = (sChip & EmptyCellChip & sChip & sChip) Then
					If IsMoveAllowed(x + 1, y) Then
						Return x + 1
					End If
				End If
				If (Board(x, y) & Board(x + 1, y) & Board(x + 2, y) & Board(x + 3, y)) = (EmptyCellChip & sChip & sChip & sChip) Then
					If IsMoveAllowed(x, y) Then
						Return x
					End If
				End If
			Next
		Next

		' Search diagonally (/)
		For y = 0 To MaxY - 3
			For x = 0 To MaxX - 3
				If (Board(x, y) & Board(x + 1, y + 1) & Board(x + 2, y + 2) & Board(x + 3, y + 3)) = (sChip & sChip & sChip & EmptyCellChip) Then
					If IsMoveAllowed(x + 3, y + 3) Then
						Return x + 3
					End If
				End If
				If (Board(x, y) & Board(x + 1, y + 1) & Board(x + 2, y + 2) & Board(x + 3, y + 3)) = (sChip & sChip & EmptyCellChip & sChip) Then
					If IsMoveAllowed(x + 2, y + 2) Then
						Return x + 2
					End If
				End If
				If (Board(x, y) & Board(x + 1, y + 1) & Board(x + 2, y + 2) & Board(x + 3, y + 3)) = (sChip & EmptyCellChip & sChip & sChip) Then
					If IsMoveAllowed(x + 1, y + 1) Then
						Return x + 1
					End If
				End If
				If (Board(x, y) & Board(x + 1, y + 1) & Board(x + 2, y + 2) & Board(x + 3, y + 3)) = (EmptyCellChip & sChip & sChip & sChip) Then
					If IsMoveAllowed(x, y) Then
						Return x
					End If
				End If
			Next
		Next

		' Search diagonally (\)
		For y = 0 To MaxY - 3
			For x = MaxX To 3 Step -1
				If (Board(x, y) & Board(x - 1, y + 1) & Board(x - 2, y + 2) & Board(x - 3, y + 3)) = (sChip & sChip & sChip & EmptyCellChip) Then
					If IsMoveAllowed(x - 3, y + 3) Then
						Return x - 3
					End If
				End If
				If (Board(x, y) & Board(x - 1, y + 1) & Board(x - 2, y + 2) & Board(x - 3, y + 3)) = (sChip & sChip & EmptyCellChip & sChip) Then
					If IsMoveAllowed(x - 2, y + 3) Then
						Return x - 2
					End If
				End If
				If (Board(x, y) & Board(x - 1, y + 1) & Board(x - 2, y + 2) & Board(x - 3, y + 3)) = (sChip & EmptyCellChip & sChip & sChip) Then
					If IsMoveAllowed(x - 1, y + 3) Then
						Return x - 1
					End If
				End If
				If (Board(x, y) & Board(x - 1, y + 1) & Board(x - 2, y + 2) & Board(x - 3, y + 3)) = (EmptyCellChip & sChip & sChip & sChip) Then
					If IsMoveAllowed(x, y + 3) Then
						Return x
					End If
				End If
			Next
		Next

		Return -1
	End Function

	' Computer AI helper method
	Private Function ItemsAroundCell(ByVal iX As Integer, ByVal sChip As String) As Integer
		Dim iY As Integer
		Dim X, Y As Integer
		Dim itemCount As Integer

		For iY = 0 To MaxY
			If Board(iX, iY) = EmptyCellChip Then Exit For
		Next

		For Y = iY - 1 To iY + 1
			For X = iX - 1 To iX + 1
				If X >= 0 And X <= MaxX And Y >= 0 And Y <= MaxY Then
					If Board(X, Y) = sChip Then
						itemCount += 1
					End If
				End If
			Next
		Next

		Return itemCount
	End Function

	' Computer AI helper method
	Private Function ChooseBestMove(ByRef Moves() As Integer, ByVal sChip As String, ByVal NumMoves As Integer) As Integer
		Dim BestMoves(MaxX) As Integer
		Dim Density(MaxX) As Integer
		Dim i, maxDensity As Integer
		Dim moveCount As Integer

		' Calculate and store the chip density around the given moves
		For i = 0 To NumMoves - 1
			Density(i) = ItemsAroundCell(Moves(i), sChip)
			If Density(i) > maxDensity Then maxDensity = Density(i)
		Next

		' Select the moves with the highest density
		For i = 0 To NumMoves - 1
			If Density(i) = maxDensity Then
				BestMoves(moveCount) = Moves(i)
				moveCount += 1
			End If
		Next

		' Randomly select and return any of the best moves
		Return BestMoves(CInt(Rnd() * (moveCount - 1)))
	End Function

	' Computer AI method (pretty impressive I think :)
	Public Function Think(Optional ByVal sPlayer As String = vbNullString) As Integer
		Dim sBoard(MaxX, MaxY) As String
		Dim iMove(MaxX) As Integer
		Dim bMoveFound As Boolean
		Dim i, iX, iMoveCount As Integer

		RaiseEvent ProcessNote("Thinking...")

		' Leave if there are no more places to think for
		If IsGameDraw() Then Return -MaxX - 1

		' Use default positions if less than 3 moves
		If GetTotalMoves() < 3 Then
			RaiseEvent ProcessNote("Initial move.")

			If Board(MaxX \ 2, 0) = EmptyCellChip Then
				Return MaxX \ 2
			ElseIf Board((MaxX \ 2) + 1, 0) = EmptyCellChip Then
				Return (MaxX \ 2) + 1
			ElseIf Board((MaxX \ 2) - 1, 0) = EmptyCellChip Then
				Return (MaxX \ 2) - 1
			End If
		End If

		' Determine the player
		If sPlayer = vbNullString Then sPlayer = Player

		' Search for winning positions
		i = ComputerSearch(sPlayer)
		If i >= 0 Then
			RaiseEvent ProcessNote("Winning move " & i + 1 & "!")
			Return i
		End If

		' Search for critical loosing positions (negative to indicate we are doing bad :()
		i = ComputerSearch(Opponent(sPlayer))
		If i >= 0 Then
			RaiseEvent ProcessNote("Defending move " & i + 1 & "!")
			Return -i
		End If

		' Make a copy of the game Board
		Array.Copy(Board, sBoard, Board.Length)

		' Play a move for 'myself'
		For i = 0 To MaxX
			If PutChipInRow(i, sPlayer) Then
				If ComputerSearch(sPlayer) >= 0 And ComputerSearch(Opponent(sPlayer)) < 0 Then
					bMoveFound = True
					iMove(iMoveCount) = i
					iMoveCount += 1
				End If
				Array.Copy(sBoard, Board, Board.Length)
			End If
		Next

		If bMoveFound Then
			i = ChooseBestMove(iMove, sPlayer, iMoveCount)
			RaiseEvent ProcessNote("Found " & i + 1 & ".")
			Return i
		End If

		bMoveFound = False
		iMoveCount = 0
		For i = 0 To MaxX
			If PutChipInRow(i, sPlayer) Then
				If ComputerSearch(Opponent(sPlayer)) < 0 Then
					bMoveFound = True
					iMove(iMoveCount) = i
					iMoveCount += 1
				End If
				Array.Copy(sBoard, Board, Board.Length)
			End If
		Next

		If bMoveFound Then
			i = ChooseBestMove(iMove, Opponent(sPlayer), iMoveCount)
			RaiseEvent ProcessNote("Found " & i + 1 & ".")
			Return i
		End If

		' Recursive game logic starts here
		Do
			' Play a random move
			Do
				i = CInt(Rnd() * MaxX)
			Loop Until PutChipInRow(i, sPlayer)

			RaiseEvent ProcessNote("Trying " & i + 1 & ".")

			iX = Think(Opponent(sPlayer))
		Loop Until iX < 0

		' Restore the game Board
		Array.Copy(sBoard, Board, Board.Length)

		' Play a random move if no move were found
		If iX < -MaxX Then
			' Play a random move
			Do
				iX = CInt(Rnd() * MaxX)
			Loop Until PutChipInRow(iX, sPlayer)

			RaiseEvent ProcessNote("Random move " & iX + 1 & ".")

			' Restore the game Board
			Array.Copy(sBoard, Board, Board.Length)
		End If

		Return iX
	End Function
End Class

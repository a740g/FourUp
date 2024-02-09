'-----------------------------------------------------------------------------------------------------------------------
' Four Up: Classic Connect 4 game
' Copyright (c) 2024 Samuel Gomes
'-----------------------------------------------------------------------------------------------------------------------

$IF FOURUPENGINE_BAS = UNDEFINED THEN
    $LET FOURUPENGINE_BAS = TRUE

    '$INCLUDE:'FourUpEngine.bi'

    '-------------------------------------------------------------------------------------------------------------------
    ' Test code for debugging the library
    '-------------------------------------------------------------------------------------------------------------------
    'OPTION _EXPLICIT
    '$CONSOLE:ONLY

    'GameInitialize 0, 0, 0

    'DIM move AS _UNSIGNED _BYTE

    'GameBoardDebugPrint

    'DO
    '    IF Game.player = GAME_BOARD_PLAYER_O THEN
    '        DO
    '            INPUT "Enter a move"; move
    '        LOOP WHILE move > Game.boardMaxX OR NOT GamePlayMove(move)
    '    END IF

    '    GameBoardDebugPrint

    '    IF Game.player = GAME_BOARD_PLAYER_X THEN
    '        IF NOT GamePlayMove(GameSolverGetBestMove(Game.player)) THEN
    '            ERROR ERROR_INTERNAL_ERROR
    '            EXIT DO
    '        END IF
    '    END IF

    '    GameBoardDebugPrint

    '    DIM winner AS _UNSIGNED _BYTE: winner = GameGetWinner(TRUE)
    'LOOP WHILE GAME_BOARD_PLAYER_NONE = winner AND NOT GameBoardIsFull

    'GameBoardDebugPrint

    'IF winner = GAME_BOARD_PLAYER_O THEN
    '    PRINT "Player O wins!"
    'ELSEIF winner = GAME_BOARD_PLAYER_X THEN
    '    PRINT "Player X wins!"
    'ELSE
    '    PRINT "It's a draw!"
    'END IF


    'SUB GameBoardDebugPrint
    '    SHARED Game AS GameType
    '    SHARED GameBoard() AS _UNSIGNED _BYTE

    '    COLOR 15, 0
    '    PRINT

    '    DIM y AS LONG: FOR y = Game.boardMaxY TO 0 STEP -1
    '        DIM x AS LONG: FOR x = 0 TO Game.boardMaxX
    '            SELECT CASE GameBoard(x, y)
    '                CASE GAME_BOARD_PLAYER_O
    '                    PRINT " o ";

    '                CASE GAME_BOARD_PLAYER_X
    '                    PRINT " x ";

    '                CASE GAME_BOARD_PLAYER_O_WIN
    '                    COLOR 14, 1
    '                    PRINT " o ";
    '                    COLOR 15, 0

    '                CASE GAME_BOARD_PLAYER_X_WIN
    '                    COLOR 14, 1
    '                    PRINT " x ";
    '                    COLOR 15, 0

    '                CASE GAME_BOARD_PLAYER_NONE
    '                    COLOR 8, 0
    '                    PRINT " . ";
    '                    COLOR 15, 0

    '                CASE ELSE
    '                    ERROR ERROR_INTERNAL_ERROR
    '            END SELECT
    '        NEXT x

    '        PRINT
    '    NEXT y

    '    PRINT
    'END SUB
    '-------------------------------------------------------------------------------------------------------------------


    ' Resets the game board and set everything for a fresh game
    SUB GameReset
        SHARED Game AS GameType
        SHARED GameBoard() AS _UNSIGNED _BYTE

        Game.moveHistory = EMPTY_STRING
        Game.moves = 0
        REDIM GameBoard(0 TO Game.boardMaxX, 0 TO Game.boardMaxY) AS _UNSIGNED _BYTE

        Game.engineLog = "Game board (" + LTRIM$(STR$(Game.boardMaxX + 1)) + " x" + STR$(Game.boardMaxY + 1) + ") reset"
    END SUB


    ' Returns the string logged by the core game code
    FUNCTION GameGetEngineLog$
        SHARED Game AS GameType

        IF LEN(Game.engineLog) > 0 THEN
            GameGetEngineLog = Game.engineLog
            Game.engineLog = EMPTY_STRING
        END IF
    END FUNCTION


    ' Gets the solver max depth
    FUNCTION GameSolverGetMaxDepth~%%
        SHARED Game AS GameType

        GameSolverGetMaxDepth = Game.solverMaxDepth
    END FUNCTION


    ' Sets the solver max depth
    SUB GameSolverSetMaxDepth (depth AS _UNSIGNED _BYTE)
        SHARED Game AS GameType

        IF depth > 0 THEN
            Game.solverMaxDepth = depth
        ELSE
            Game.solverMaxDepth = GAME_SOLVER_DEFAULT_DEPTH
        END IF

        Game.engineLog = "Solver depth:" + STR$(Game.solverMaxDepth)
    END SUB


    ' Initializes the game and the game board
    SUB GameInitialize (w AS _UNSIGNED _BYTE, h AS _UNSIGNED _BYTE, depth AS _UNSIGNED _BYTE)
        SHARED Game AS GameType
        SHARED GameBoard() AS _UNSIGNED _BYTE

        Game.player = GAME_BOARD_PLAYER_O

        IF w > 0 THEN
            Game.boardMaxX = w - 1
        ELSE
            Game.boardMaxX = GAME_BOARD_DEFAULT_MAX_X
        END IF

        IF h > 0 THEN
            Game.boardMaxY = h - 1
        ELSE
            Game.boardMaxY = GAME_BOARD_DEFAULT_MAX_Y
        END IF

        GameReset
        GameSolverSetMaxDepth depth
    END SUB


    ' Returns the number of moves played
    FUNCTION GameGetMoves~%
        SHARED Game AS GameType

        GameGetMoves = Game.moves
    END FUNCTION


    ' Checks if a move is valid in the given column
    FUNCTION GameIsValidMove%% (x AS _UNSIGNED _BYTE)
        SHARED Game AS GameType
        SHARED GameBoard() AS _UNSIGNED _BYTE

        GameIsValidMove = (GameBoard(x, Game.boardMaxY) = GAME_BOARD_PLAYER_NONE)
    END FUNCTION


    ' Function to check if the board is full (This would me a tie if there are no winners)
    FUNCTION GameBoardIsFull%%
        SHARED Game AS GameType
        SHARED GameBoard() AS _UNSIGNED _BYTE

        ' Simply check all top positions on the board
        DIM x AS LONG: FOR x = 0 TO Game.boardMaxX
            IF GameBoard(x, Game.boardMaxY) = GAME_BOARD_PLAYER_NONE THEN EXIT FUNCTION ' the board is not full
        NEXT x

        GameBoardIsFull = TRUE ' the board is full
    END FUNCTION


    ' Returns the winning player if any
    FUNCTION GameGetWinner~%% (markSpots AS _BYTE)
        SHARED Game AS GameType
        SHARED GameBoard() AS _UNSIGNED _BYTE

        DIM AS LONG x, y

        ' Check horizontally (-)
        FOR y = 0 TO Game.boardMaxY
            FOR x = 0 TO Game.boardMaxX - 3
                IF GameBoard(x, y) <> GAME_BOARD_PLAYER_NONE THEN
                    IF GameBoard(x, y) = GameBoard(x + 1, y) AND GameBoard(x, y) = GameBoard(x + 2, y) AND GameBoard(x, y) = GameBoard(x + 3, y) THEN
                        GameGetWinner = GameBoard(x, y)

                        IF markSpots THEN
                            GameBoard(x, y) = GameBoard(x, y) + GAME_BOARD_PLAYER_WIN_OFFSET
                            GameBoard(x + 1, y) = GameBoard(x, y)
                            GameBoard(x + 2, y) = GameBoard(x, y)
                            GameBoard(x + 3, y) = GameBoard(x, y)
                        END IF
                        EXIT FUNCTION
                    END IF
                END IF
            NEXT x
        NEXT y

        ' Check vertically (|)
        FOR x = 0 TO Game.boardMaxX
            FOR y = 0 TO Game.boardMaxY - 3
                IF GameBoard(x, y) <> GAME_BOARD_PLAYER_NONE THEN
                    IF GameBoard(x, y) = GameBoard(x, y + 1) AND GameBoard(x, y) = GameBoard(x, y + 2) AND GameBoard(x, y) = GameBoard(x, y + 3) THEN
                        GameGetWinner = GameBoard(x, y)

                        IF markSpots THEN
                            GameBoard(x, y) = GameBoard(x, y) + GAME_BOARD_PLAYER_WIN_OFFSET
                            GameBoard(x, y + 1) = GameBoard(x, y)
                            GameBoard(x, y + 2) = GameBoard(x, y)
                            GameBoard(x, y + 3) = GameBoard(x, y)
                        END IF
                        EXIT FUNCTION
                    END IF
                END IF
            NEXT y
        NEXT x

        ' Check diagonally (/)
        FOR y = 0 TO Game.boardMaxY - 3
            FOR x = 0 TO Game.boardMaxX - 3
                IF GameBoard(x, y) <> GAME_BOARD_PLAYER_NONE THEN
                    IF GameBoard(x, y) = GameBoard(x + 1, y + 1) AND GameBoard(x, y) = GameBoard(x + 2, y + 2) AND GameBoard(x, y) = GameBoard(x + 3, y + 3) THEN
                        GameGetWinner = GameBoard(x, y)

                        IF markSpots THEN
                            GameBoard(x, y) = GameBoard(x, y) + GAME_BOARD_PLAYER_WIN_OFFSET
                            GameBoard(x + 1, y + 1) = GameBoard(x, y)
                            GameBoard(x + 2, y + 2) = GameBoard(x, y)
                            GameBoard(x + 3, y + 3) = GameBoard(x, y)
                        END IF
                        EXIT FUNCTION
                    END IF
                END IF
            NEXT x
        NEXT y

        ' Check diagonally (\)
        FOR y = 0 TO Game.boardMaxY - 3
            FOR x = Game.boardMaxX TO 3 STEP -1
                IF GameBoard(x, y) <> GAME_BOARD_PLAYER_NONE THEN
                    IF GameBoard(x, y) = GameBoard(x - 1, y + 1) AND GameBoard(x, y) = GameBoard(x - 2, y + 2) AND GameBoard(x, y) = GameBoard(x - 3, y + 3) THEN
                        GameGetWinner = GameBoard(x, y)

                        IF markSpots THEN
                            GameBoard(x, y) = GameBoard(x, y) + GAME_BOARD_PLAYER_WIN_OFFSET
                            GameBoard(x - 1, y + 1) = GameBoard(x, y)
                            GameBoard(x - 2, y + 2) = GameBoard(x, y)
                            GameBoard(x - 3, y + 3) = GameBoard(x, y)
                        END IF
                        EXIT FUNCTION
                    END IF
                END IF
            NEXT x
        NEXT y

        GameGetWinner = GAME_BOARD_PLAYER_NONE
    END FUNCTION


    ' Makes a move on the game board
    FUNCTION GameMakeMoveInternal%% (x AS _UNSIGNED _BYTE, player AS _UNSIGNED _BYTE)
        SHARED Game AS GameType
        SHARED GameBoard() AS _UNSIGNED _BYTE

        IF GameIsValidMove(x) THEN
            DIM y AS LONG: FOR y = 0 TO Game.boardMaxY
                IF GameBoard(x, y) = GAME_BOARD_PLAYER_NONE THEN
                    GameBoard(x, y) = player
                    GameMakeMoveInternal = TRUE
                    EXIT FUNCTION
                END IF
            NEXT y
        END IF
    END FUNCTION


    ' Undoes the last move in the given column
    SUB GameUndoMoveInternal (x AS _UNSIGNED _BYTE)
        SHARED Game AS GameType
        SHARED GameBoard() AS _UNSIGNED _BYTE

        DIM y AS LONG: FOR y = Game.boardMaxY TO 0 STEP -1
            IF GameBoard(x, y) <> GAME_BOARD_PLAYER_NONE THEN
                GameBoard(x, y) = GAME_BOARD_PLAYER_NONE
                EXIT SUB
            END IF
        NEXT y

        ERROR ERROR_INTERNAL_ERROR ' game logic screwed?
    END SUB


    ' Plays move x using the current player
    ' If the move is successful, it switches the player
    FUNCTION GamePlayMove (x AS _UNSIGNED _BYTE)
        SHARED Game AS GameType

        IF GameMakeMoveInternal(x, Game.player) THEN
            ' Increment the total moves
            Game.moves = Game.moves + 1
            ' Add the move to the move history
            Game.moveHistory = Game.moveHistory + CHR$(Game.player + x)
            ' Switch the player
            Game.player = GameGetOpponent(Game.player)

            GamePlayMove = TRUE
        END IF
    END FUNCTION


    ' Undoes the move made by the last player and then switches the player
    SUB GameUndoMove
        SHARED Game AS GameType

        IF Game.moves > 0 THEN
            ' Switch the player
            Game.player = GameGetOpponent(Game.player)
            ' Get rid of the last move from the board. Last move = saved_value - last_player. 129 - 129 = 0, 130 - 129 = 1, 1 - 1 = 0 etc.
            GameUndoMoveInternal ASC(Game.moveHistory, LEN(Game.moveHistory)) - Game.player
            ' Get rid of the move from the move history
            Game.moveHistory = LEFT$(Game.moveHistory, LEN(Game.moveHistory) - 1)
            ' Decrement the total moves
            Game.moves = Game.moves - 1
        END IF
    END SUB


    ' Returns the current player
    FUNCTION GameGetPlayer~%%
        SHARED Game AS GameType

        GameGetPlayer = Game.player
    END FUNCTION


    ' Get the opponent for a given player
    FUNCTION GameGetOpponent~%% (player AS _UNSIGNED _BYTE)
        IF player = GAME_BOARD_PLAYER_O OR player = GAME_BOARD_PLAYER_X THEN
            ' 1 + 129 - 1 = 129
            ' 1 + 129 - 129 = 1
            GameGetOpponent = 1 + GAME_BOARD_PLAYER_X - player
        ELSE
            ERROR ERROR_INTERNAL_ERROR
        END IF
    END FUNCTION


    ' Helper function to evaluate a line (row, column, or diagonal)
    ' Returns a positive score if the line has more player's pieces, negative if opponent's, and 0 otherwise
    FUNCTION GameBoardEvaluateLine& (player AS _UNSIGNED _BYTE, a AS _UNSIGNED _BYTE, b AS _UNSIGNED _BYTE, c AS _UNSIGNED _BYTE, d AS _UNSIGNED _BYTE)
        DIM AS LONG playerCount, opponentCount

        IF player = a THEN playerCount = 1
        IF player = b THEN playerCount = playerCount + 1
        IF player = c THEN playerCount = playerCount + 1
        IF player = d THEN playerCount = playerCount + 1
        ' Bump the score if we have connect 3s
        IF (a = b AND a = c) OR (d = c AND d = b) THEN playerCount = playerCount * playerCount * playerCount

        DIM opponent AS _UNSIGNED _BYTE: opponent = GameGetOpponent(player)
        IF opponent = a THEN opponentCount = 1
        IF opponent = b THEN opponentCount = opponentCount + 1
        IF opponent = c THEN opponentCount = opponentCount + 1
        IF opponent = d THEN opponentCount = opponentCount + 1
        ' Bump the score if we have connect 3s
        IF (a = b AND a = c) OR (d = c AND d = b) THEN opponentCount = opponentCount * opponentCount * opponentCount

        GameBoardEvaluateLine = playerCount - opponentCount
    END FUNCTION


    ' Counts the number of player's pieces in all possible winning combinations and subtracts the opponent's count
    FUNCTION GameBoardEvaluate& (player AS _UNSIGNED _BYTE)
        SHARED Game AS GameType
        SHARED GameBoard() AS _UNSIGNED _BYTE

        DIM AS LONG x, y, score

        ' Check horizontally (-)
        FOR y = 0 TO Game.boardMaxY
            FOR x = 0 TO Game.boardMaxX - 3
                score = score + GameBoardEvaluateLine(player, GameBoard(x, y), GameBoard(x + 1, y), GameBoard(x + 2, y), GameBoard(x + 3, y))
            NEXT x
        NEXT y

        ' Check vertically (|)
        FOR x = 0 TO Game.boardMaxX
            FOR y = 0 TO Game.boardMaxY - 3
                score = score + GameBoardEvaluateLine(player, GameBoard(x, y), GameBoard(x, y + 1), GameBoard(x, y + 2), GameBoard(x, y + 3))
            NEXT y
        NEXT x

        ' Check diagonally (/)
        FOR y = 0 TO Game.boardMaxY - 3
            FOR x = 0 TO Game.boardMaxX - 3
                score = score + GameBoardEvaluateLine(player, GameBoard(x, y), GameBoard(x + 1, y + 1), GameBoard(x + 2, y + 2), GameBoard(x + 3, y + 3))
            NEXT x
        NEXT y

        ' Check diagonally (\)
        FOR y = 0 TO Game.boardMaxY - 3
            FOR x = Game.boardMaxX TO 3 STEP -1
                score = score + GameBoardEvaluateLine(player, GameBoard(x, y), GameBoard(x - 1, y + 1), GameBoard(x - 2, y + 2), GameBoard(x - 3, y + 3))
            NEXT x
        NEXT y

        GameBoardEvaluate = score
    END FUNCTION


    ' Negamax algorithm with alpha-beta pruning
    FUNCTION GameSolverNegamaxAlphaBeta& (depth AS _UNSIGNED _BYTE, alpha AS LONG, beta AS LONG, player AS _UNSIGNED _BYTE)
        SHARED Game AS GameType

        ' Terminal condition: Get the winner if any and return an appropriate value
        DIM winner AS _UNSIGNED _BYTE: winner = GameGetWinner(FALSE)
        IF winner <> GAME_BOARD_PLAYER_NONE THEN
            IF winner = player THEN
                GameSolverNegamaxAlphaBeta = GAME_SOLVER_INFINITY
            ELSE
                GameSolverNegamaxAlphaBeta = -GAME_SOLVER_INFINITY
            END IF

            EXIT FUNCTION
        END IF

        ' Terminal condition: if depth is 0 or the game is over, return the board's evaluation
        IF depth = 0 OR GameBoardIsFull THEN
            GameSolverNegamaxAlphaBeta = GameBoardEvaluate(player)
            EXIT FUNCTION
        END IF

        ' Initialize best value to a super negative value
        DIM bestScore AS LONG: bestScore = -GAME_SOLVER_INFINITY

        ' Loop through each valid move (column) on the board
        DIM x AS LONG: FOR x = 0 TO Game.boardMaxX
            ' Make move
            IF GameMakeMoveInternal(x, player) THEN
                ' Recursively call negamax with the opponent's turn
                DIM score AS LONG: score = -GameSolverNegamaxAlphaBeta(depth - 1, -beta, -alpha, GameGetOpponent(player))

                ' Undo move
                GameUndoMoveInternal x

                ' Update best value
                IF score > bestScore THEN bestScore = score

                ' Alpha-beta pruning
                IF score > alpha THEN alpha = score
                IF alpha >= beta THEN EXIT FOR ' prune branch
            END IF
        NEXT x

        GameSolverNegamaxAlphaBeta = bestScore
    END FUNCTION


    ' Finds the best move using Negamax with alpha-beta pruning
    FUNCTION GameSolverGetBestMove~%% (player AS _UNSIGNED _BYTE)
        SHARED Game AS GameType

        DIM opponent AS _UNSIGNED _BYTE: opponent = GameGetOpponent(player)

        ' Quickly check winning and loosing positions to avoid costly Negamax search
        DIM x AS LONG: FOR x = 0 TO Game.boardMaxX
            IF GameMakeMoveInternal(x, player) THEN
                IF GameGetWinner(FALSE) = player THEN
                    GameUndoMoveInternal x
                    GameSolverGetBestMove = x
                    Game.engineLog = "Winning move:" + STR$(x + 1)
                    EXIT FUNCTION
                END IF

                GameUndoMoveInternal x
            END IF

            IF GameMakeMoveInternal(x, opponent) THEN
                IF GameGetWinner(FALSE) = opponent THEN
                    GameUndoMoveInternal x
                    GameSolverGetBestMove = x
                    Game.engineLog = "Defending move:" + STR$(x + 1)
                    EXIT FUNCTION
                END IF

                GameUndoMoveInternal x
            END IF
        NEXT x

        DIM AS _UNSIGNED _BYTE move, bestMove
        DIM bestScore AS LONG: bestScore = -GAME_SOLVER_INFINITY

        FOR x = 0 TO Game.boardMaxX
            IF GameMakeMoveInternal(x, player) THEN
                move = x ' save the move

                DIM score AS LONG: score = -GameSolverNegamaxAlphaBeta(Game.solverMaxDepth - 1, -GAME_SOLVER_INFINITY, -bestScore, opponent)
                Game.engineLog = "Score (" + LTRIM$(STR$(x + 1)) + " ): " + LTRIM$(STR$(score))
                GameUndoMoveInternal x

                IF score > bestScore THEN
                    bestScore = score
                    bestMove = x
                END IF
            END IF
        NEXT x

        IF NOT GameIsValidMove(bestMove) THEN bestMove = move

        Game.engineLog = "Best move:" + STR$(bestMove + 1)

        GameSolverGetBestMove = bestMove
    END FUNCTION

$END IF

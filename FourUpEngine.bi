'-----------------------------------------------------------------------------------------------------------------------
' Four Up: Classic Connect 4 game
' Copyright (c) 2024 Samuel Gomes
'-----------------------------------------------------------------------------------------------------------------------

$IF FOURUPENGINE_BI = UNDEFINED THEN
    $LET FOURUPENGINE_BI = TRUE

    ' InForm defines TRUE & FALSE. So we'll wrap this to avoid warnings
    $IF INFORMCOMMON_BI = UNDEFINED THEN
        CONST FALSE%% = 0%%, TRUE%% = NOT FALSE
    $END IF

    CONST EMPTY_STRING = ""

    CONST ERROR_ILLEGAL_FUNCTION_CALL~%% = 5~%%
    CONST ERROR_CANNOT_CONTINUE~%% = 17~%%
    CONST ERROR_INTERNAL_ERROR~%% = 51~%%
    CONST ERROR_FEATURE_UNAVAILABLE~%% = 73~%%

    CONST GAME_SOLVER_INFINITY& = 2147483647&
    CONST GAME_SOLVER_DEFAULT_DEPTH~%% = 6~%%
    CONST GAME_BOARD_DEFAULT_MAX_X~%% = 6~%%
    CONST GAME_BOARD_DEFAULT_MAX_Y~%% = 5~%%
    CONST GAME_BOARD_PLAYER_NONE~%% = 0~%%
    CONST GAME_BOARD_PLAYER_O~%% = 1~%%
    CONST GAME_BOARD_PLAYER_X~%% = 129~%%
    CONST GAME_BOARD_PLAYER_WIN_OFFSET~%% = 64~%%
    CONST GAME_BOARD_PLAYER_O_WIN~%% = GAME_BOARD_PLAYER_O + GAME_BOARD_PLAYER_WIN_OFFSET
    CONST GAME_BOARD_PLAYER_X_WIN~%% = GAME_BOARD_PLAYER_X + GAME_BOARD_PLAYER_WIN_OFFSET

    TYPE GameType
        player AS _UNSIGNED _BYTE ' the current player (to play)
        moveHistory AS STRING ' the move history (player 1: 1, 2, 3...; player 2: 129, 130 ,131...)
        moves AS _UNSIGNED INTEGER ' total number of moves played
        boardMaxX AS _UNSIGNED _BYTE
        boardMaxY AS _UNSIGNED _BYTE
        solverMaxDepth AS _UNSIGNED _BYTE
        engineLog AS STRING
    END TYPE

    ' This holds the state of the game
    DIM Game AS GameType
    ' This array is the actual game board where (0, 0) is the left-bottom position
    REDIM GameBoard(0 TO 0, 0 TO 0) AS _UNSIGNED _BYTE

$END IF

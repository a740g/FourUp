# FOUR UP

[Four Up](https://en.wikipedia.org/wiki/Connect_Four) (also known as Connect 4, Connect Four, Plot Four, Find Four, Captain's Mistress, Four in a Row, Drop Four, and Gravitrips in the Soviet Union) is a two-player strategy game played on a 7-column by 6-row board. Each player has a color and drops successively a disc of his color in one column, the disc falls down to the lowest empty cell of the column. The first player to make an alignment of four discs of his color wins, if the board is filled without alignment it’s a draw game.

![Screenshot](screenshot.png)

The source code has hopped several developer tools and operating systems. From the good old 16-bit MS-DOS to 64-bit Windows, Linux & macOS.

- [QB64-PE](https://github.com/QB64-Phoenix-Edition/QB64pe) + [Negamax](https://en.wikipedia.org/wiki/Negamax) solver
- [Visual Basic .Net](https://visualstudio.microsoft.com/free-developer-offers/) + [Minimax](https://en.wikipedia.org/wiki/Minimax) solver
- [Visual Basic .Net](https://visualstudio.microsoft.com/free-developer-offers/) + Crude solver
- [Visual Basic 6.0](https://winworldpc.com/product/microsoft-visual-bas/60) + Crude solver
- [Microsoft Visual Basic 1.0 for DOS](https://winworldpc.com/product/microsoft-visual-bas/10-for-dos) + Random play
- [Microsoft BASIC PDS 7.1](https://winworldpc.com/product/microsoft-basic/pds-71) + Random play
- [QuickBASIC 4.5](https://winworldpc.com/product/quickbasic/45) + Random play

The Visual Basic .Net sources can be found [here](https://github.com/a740g/FourUp/tree/c906e9fa1fca70ce31ccda98e93ee7e2fc280eef).

## FEATURES

- Works natively on Windows, Linux & macOS
- Uses [InFrom-PE](https://github.com/a740g/InForm-PE) GUI engine for [QB64-PE](https://github.com/QB64-Phoenix-Edition/QB64pe)

## USAGE

- Clone the repository to a directory of your choice
- Open Terminal and change to the directory using an appropriate OS command
- Run `git submodule update --init --recursive` to initialize, fetch and checkout git submodules
- Open *FourUp.bas* in the QB64-PE IDE and press `F5` to compile and run

## NOTES

This requires the latest version of [QB64-PE](https://github.com/QB64-Phoenix-Edition/QB64pe/releases/latest). QB64, or other forks of QB64 will not work!

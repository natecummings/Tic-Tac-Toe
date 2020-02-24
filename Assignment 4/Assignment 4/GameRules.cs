using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class GameRules
    {
        /// <summary>
        /// String array of the playing board 
        /// </summary>
        public string[,] saBoard;

        /// <summary>
        /// Create a variable of the enum type for the winning moves
        /// </summary>
        public WinningMove eWinningMove;

        /// <summary>
        /// Enum of different winning moves
        /// </summary>
        public enum WinningMove
        {
            Row1,
            Row2,
            Row3,
            Col1,
            Col2,
            Col3,
            Diag1,
            Diag2
        }

        /// <summary>
        /// Calls other methods to determine if there is a win on the board.
        /// </summary>
        public bool IsWinningMove()
        {
            if (isVertWin())
            {
                return true;
            }
            else if (isHorzWin())
            {
                return true;
            }
            else if (isDiagWin())
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Determines if there is a vertical win on the board and which vertical win it is
        /// </summary>
        private bool isVertWin()
        {
            if (saBoard[0, 0] == saBoard[0, 1] && saBoard[0, 1] == saBoard[0, 2] && saBoard[0,0] != " ")
            {
                eWinningMove = WinningMove.Col1;
                return true;
            }
            else if (saBoard[1, 0] == saBoard[1, 1] && saBoard[1, 1] == saBoard[1, 2] && saBoard[1, 0] != " ")
            {
                eWinningMove = WinningMove.Col2;
                return true;
            }
            else if (saBoard[2, 0] == saBoard[2, 1] && saBoard[2, 1] == saBoard[2, 2] && saBoard[2, 0] != " ")
            {
                eWinningMove = WinningMove.Col3;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Determines if there is a horizontal win on the board and which horizontal win it is
        /// </summary>
        private bool isHorzWin()
        {
            if (saBoard[0, 0] == saBoard[1, 0] && saBoard[1, 0] == saBoard[2, 0] && saBoard[0, 0] != " ")
            {
                eWinningMove = WinningMove.Row1;
                return true;
            }
            else if (saBoard[0, 1] == saBoard[1, 1] && saBoard[1, 1] == saBoard[2, 1] && saBoard[0, 1] != " ")
            {
                eWinningMove = WinningMove.Row2;
                return true;
            }
            else if (saBoard[0, 2] == saBoard[1, 2] && saBoard[1, 2] == saBoard[2, 2] && saBoard[0, 2] != " ")
            {
                eWinningMove = WinningMove.Row3;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Determines if there is a diagonal win on the board and which diagonal win it is
        /// </summary>
        private bool isDiagWin()
        {
            if (saBoard[0, 0] == saBoard[1, 1] && saBoard[1, 1] == saBoard[2, 2] && saBoard[0, 0] != " ")
            {
                eWinningMove = WinningMove.Diag1;
                return true;
            }
            else if (saBoard[0, 2] == saBoard[1, 1] && saBoard[1, 1] == saBoard[2, 0] && saBoard[0, 2] != " ")
            {
                eWinningMove = WinningMove.Diag2;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Determines if all of the spots have been chosen and the board is full.
        /// </summary>
        public bool isTie()
        {
            // If all of the spots are full then return true
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (saBoard[i, j] == " ")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}   

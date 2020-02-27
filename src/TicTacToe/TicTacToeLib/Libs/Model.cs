using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib.Libs
{
    public class Model
    {
        public char WinPlayer { get; set; }
        public bool IsWin { get; private set; }

        public char[] Board = new char[9];

        public void CheckWinner()
        {
            #region Horizontal Checking for X
            if ((Board[0] == 'X') && (Board[1] == 'X') && (Board[2] == 'X')) { IsWin = true; WinPlayer = 'X'; return; }
            if ((Board[3] == 'X') && (Board[4] == 'X') && (Board[5] == 'X')) { IsWin = true; WinPlayer = 'X'; return; }
            if ((Board[6] == 'X') && (Board[7] == 'X') && (Board[8] == 'X')) { IsWin = true; WinPlayer = 'X'; return; }
            #endregion

            #region Vertical Checking for X
            if ((Board[0] == 'X') && (Board[3] == 'X') && (Board[6] == 'X')) { IsWin = true; WinPlayer = 'X'; return; }
            if ((Board[1] == 'X') && (Board[4] == 'X') && (Board[7] == 'X')) { IsWin = true; WinPlayer = 'X'; return; }
            if ((Board[2] == 'X') && (Board[5] == 'X') && (Board[8] == 'X')) { IsWin = true; WinPlayer = 'X'; return; }

            #endregion

            #region Diagoanl Checking for X
            if ((Board[0] == 'X') && (Board[4] == 'X') && (Board[8] == 'X')) { IsWin = true; WinPlayer = 'X'; return; }
            if ((Board[2] == 'X') && (Board[4] == 'X') && (Board[6] == 'X')) { IsWin = true; WinPlayer = 'X'; return; }
            #endregion

            #region Horizontal Checking for Y
            if ((Board[0] == 'Y') && (Board[1] == 'Y') && (Board[2] == 'Y')) { IsWin = true; WinPlayer = 'Y'; return; }
            if ((Board[3] == 'Y') && (Board[4] == 'Y') && (Board[5] == 'Y')) { IsWin = true; WinPlayer = 'Y'; return; }
            if ((Board[6] == 'Y') && (Board[7] == 'Y') && (Board[8] == 'Y')) { IsWin = true; WinPlayer = 'Y'; return; }
            #endregion

            #region Vertical Checking for Y
            if ((Board[0] == 'Y') && (Board[3] == 'Y') && (Board[6] == 'Y')) { IsWin = true; WinPlayer = 'Y'; return; }
            if ((Board[1] == 'Y') && (Board[4] == 'Y') && (Board[7] == 'Y')) { IsWin = true; WinPlayer = 'Y'; return; }
            if ((Board[2] == 'Y') && (Board[5] == 'Y') && (Board[8] == 'Y')) { IsWin = true; WinPlayer = 'Y'; return; }

            #endregion

            #region Diagoanl Checking for Y
            if ((Board[0] == 'Y') && (Board[4] == 'Y') && (Board[8] == 'Y')) { IsWin = true; WinPlayer = 'Y'; return; }
            if ((Board[2] == 'Y') && (Board[4] == 'Y') && (Board[6] == 'Y')) { IsWin = true; WinPlayer = 'Y'; return; }
            #endregion
        }
    }
}

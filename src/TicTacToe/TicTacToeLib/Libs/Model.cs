﻿using System;
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
        public bool PlayerOne { get;  set; }
        public int ScoreX { get; set; }
        public int ScoreO { get; set; }

        public char[] Board = new char[9];

        public Model()
        {
            this.WinPlayer = WinPlayer;
            this.IsWin = IsWin;
            this.PlayerOne = PlayerOne;
            this.ScoreX = ScoreO;
            this.ScoreO = ScoreX;
        }

        public void GetScore()
        {
            if (WinPlayer == 'X')
                ScoreX++;
            else if (WinPlayer == 'O')
                ScoreO++;
            else
                return ;
        }

        public void CheckWinner()
        {
            #region Horizontal Checking for X
            if ((Board[0] == 'X') && (Board[1] == 'X') && (Board[2] == 'X')) { IsWin = true; WinPlayer = 'X'; GetScore(); return; }
            if ((Board[3] == 'X') && (Board[4] == 'X') && (Board[5] == 'X')) { IsWin = true; WinPlayer = 'X'; GetScore(); return; }
            if ((Board[6] == 'X') && (Board[7] == 'X') && (Board[8] == 'X')) { IsWin = true; WinPlayer = 'X'; GetScore(); return; }
            #endregion

            #region Vertical Checking for X
            if ((Board[0] == 'X') && (Board[3] == 'X') && (Board[6] == 'X')) { IsWin = true; WinPlayer = 'X'; GetScore(); return; }
            if ((Board[1] == 'X') && (Board[4] == 'X') && (Board[7] == 'X')) { IsWin = true; WinPlayer = 'X'; GetScore(); return; }
            if ((Board[2] == 'X') && (Board[5] == 'X') && (Board[8] == 'X')) { IsWin = true; WinPlayer = 'X'; GetScore(); return; }

            #endregion

            #region Diagonal Checking for X
            if ((Board[0] == 'X') && (Board[4] == 'X') && (Board[8] == 'X')) { IsWin = true; WinPlayer = 'X'; GetScore(); return; }
            if ((Board[2] == 'X') && (Board[4] == 'X') && (Board[6] == 'X')) { IsWin = true; WinPlayer = 'X'; GetScore(); return; }
            #endregion

            #region Horizontal Checking for Y
            if ((Board[0] == 'O') && (Board[1] == 'O') && (Board[2] == 'O')) { IsWin = true; WinPlayer = 'O'; GetScore(); return; }
            if ((Board[3] == 'O') && (Board[4] == 'O') && (Board[5] == 'O')) { IsWin = true; WinPlayer = 'O'; GetScore(); return; }
            if ((Board[6] == 'O') && (Board[7] == 'O') && (Board[8] == 'O')) { IsWin = true; WinPlayer = 'O'; GetScore(); return; }
            #endregion

            #region Vertical Checking for Y
            if ((Board[0] == 'O') && (Board[3] == 'O') && (Board[6] == 'O')) { IsWin = true; WinPlayer = 'O'; GetScore(); return; }
            if ((Board[1] == 'O') && (Board[4] == 'O') && (Board[7] == 'O')) { IsWin = true; WinPlayer = 'O'; GetScore(); return; }
            if ((Board[2] == 'O') && (Board[5] == 'O') && (Board[8] == 'O')) { IsWin = true; WinPlayer = 'O'; GetScore(); return; }

            #endregion

            #region Diagonal Checking for Y
            if ((Board[0] == 'O') && (Board[4] == 'O') && (Board[8] == 'O')) { IsWin = true; WinPlayer = 'O'; GetScore(); return; }
            if ((Board[2] == 'O') && (Board[4] == 'O') && (Board[6] == 'O')) { IsWin = true; WinPlayer = 'O'; GetScore(); return; }
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLib.Libs;

namespace TicTacToeDesktopForms
{
    public partial class GameForm : Form
    {
        Model m = new Model();
        int startedPlayer;
        int currentPlayer;
        int[,] values = new int[3, 3];

        public GameForm()
        {
            InitializeComponent();
        }

        private void NewGame()
        {
            foreach(Control c in Controls)
            {
                try
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                    button.Text = "";
                }
                catch { }
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    values[i, j] = 0;
                }
            }

            if(startedPlayer == 1)
            {
                startedPlayer = 2;
                currentPlayer = 2;
            }
            else if(startedPlayer == 2)
            {
                startedPlayer = 1;
                currentPlayer = 1;
            }
        }

        private void DiagonalsCheck()
        {
            int playerOneCounter = 0;
            int playerTwoCounter = 0;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (i == j && values[j, i] == 1)
                    {
                        playerOneCounter++;
                    }
                    if (i == j && values[j, i] == 2)
                    {
                        playerTwoCounter++;
                    }

                    if (playerOneCounter == 3)
                    {
                        PlayerOneScoreLabel.Text = Convert.ToString(Convert.ToInt32(PlayerOneScoreLabel.Text) + 1);
                        DialogResult winDialog = MessageBox.Show("Wygrał Gracz 1! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if(winDialog == DialogResult.Yes)
                        {
                            NewGame();
                        }
                        else if (winDialog == DialogResult.No)
                        {
                            Dispose();
                        }
                    }

                    if (playerTwoCounter == 3)
                    {
                        PlayerTwoScoreLabel.Text = Convert.ToString(Convert.ToInt32(PlayerTwoScoreLabel.Text) + 1);
                        DialogResult winDialog = MessageBox.Show("Wygrał Gracz 2! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (winDialog == DialogResult.Yes)
                        {
                            NewGame();
                        }
                        else if (winDialog == DialogResult.No)
                        {
                            Dispose();
                        }
                    }
                }
            }
        }

        private void RowsCheck()
        {

        }

         private void ColumnsCheck()
        {

        }

        private void DrawForm()
        {
            DialogResult dialog = MessageBox.Show("Remis! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo);

            if(dialog == DialogResult.Yes)
            {
                NewGame();
            }
            else if(dialog == DialogResult.No)
            {
                Dispose();
            }
        }

        private void GameFormLoad(object sender, EventArgs e)
        {
            currentPlayer = 1;
        }

        private void NowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void OGrzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void JakGraćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HowToPlayForm().Show();
        }

        private void WyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if(currentPlayer == 1)
            {
                button1.Text = "X";
                currentPlayer = 2;
            }
            else if(currentPlayer == 2)
            {
                button1.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (currentPlayer == 1)
            {
                button2.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                button2.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (currentPlayer == 1)
            {
                button3.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                button3.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (currentPlayer == 1)
            {
                button4.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                button4.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (currentPlayer == 1)
            {
                button5.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                button5.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (currentPlayer == 1)
            {
                button6.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                button6.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            if (currentPlayer == 1)
            {
                button7.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                button7.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (currentPlayer == 1)
            {
                button8.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                button8.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            if (currentPlayer == 1)
            {
                button9.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                button9.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
        }
    }
}

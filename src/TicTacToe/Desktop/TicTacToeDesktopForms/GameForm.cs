using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using TicTacToeLib.Libs;

namespace TicTacToeDesktopForms
{
    public partial class GameForm : Form
    {
        Prompt prompt = new Prompt();
        int startedPlayer;
        int currentPlayer;
        int[,] values = new int[3, 3];

        public GameForm()
        {
            InitializeComponent();
        }

        private void NewGame()
        {
            foreach (Control c in Controls)
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
                        DialogResult winDialog = MessageBox.Show("Wygrał Gracz 1! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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
                        DialogResult winDialog = MessageBox.Show("Wygrał Gracz 2! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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
            int playerOneCounter = 0;
            int playerTwoCounter = 0;

            for (int i = 0; i < 3; i++)
            {
                playerOneCounter = 0;
                playerTwoCounter = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (values[i, j] == 1)
                    {
                        playerOneCounter++;
                    }
                    if (values[i, j] == 2)
                    {
                        playerTwoCounter++;
                    }

                    if (playerOneCounter == 3)
                    {
                        PlayerOneScoreLabel.Text = Convert.ToString(Convert.ToInt32(PlayerOneScoreLabel.Text) + 1);
                        DialogResult winDialog = MessageBox.Show("Wygrał Gracz 1! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (winDialog == DialogResult.Yes)
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
                        DialogResult winDialog = MessageBox.Show("Wygrał Gracz 2! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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

        
        private void ColumnsCheck()
        {
            int playerOneCounter = 0;
            int playerTwoCounter = 0;

            for (int i = 0; i < 3; i++)
            {
                playerOneCounter = 0;
                playerTwoCounter = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (values[j, i] == 1)
                    {
                        playerOneCounter++;
                    }
                    if (values[j, i] == 2)
                    {
                        playerTwoCounter++;
                    }

                    if (playerOneCounter == 3)
                    {
                        PlayerOneScoreLabel.Text = Convert.ToString(Convert.ToInt32(PlayerOneScoreLabel.Text) + 1);
                        DialogResult winDialog = MessageBox.Show("Wygrał Gracz 1! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (winDialog == DialogResult.Yes)
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
                        DialogResult winDialog = MessageBox.Show("Wygrał Gracz 2! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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

        private void DrawForm()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button button = (Button)c;

                    if (button.Enabled == false)
                    {
                        DialogResult dialog = MessageBox.Show("Remis! Czy chcesz zagrać jeszcze raz?", "Koniec Gry", MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                            NewGame();
                        }
                        else if (dialog == DialogResult.No)
                        {
                            Dispose();
                        }
                    }
                }
            }
            catch { }
        }

        private void GameFormLoad(object sender, EventArgs e)
        {
            currentPlayer = 1;
            PlayerOneLabel.Text = prompt.ShowDialog("Nazwa użytkownika", "Podaj nazwe gracza 1");
            PlayerTwoLabel.Text = prompt.ShowDialog("Nazwa użytkownika", "Podaj nazwe gracza 2");
        }

        private void NowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            PlayerOneScoreLabel.Text = "0";
            PlayerTwoScoreLabel.Text = "0";
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
                values[0, 0] = 1;
                button1.Text = "X";
                currentPlayer = 2;
            }
            else if(currentPlayer == 2)
            {
                values[0, 0] = 2;
                button1.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck(); 
            RowsCheck(); 
            ColumnsCheck();
            //DrawForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (currentPlayer == 1)
            {
                values[0, 1] = 1;
                button2.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                values[0, 1] = 2;
                button2.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
            RowsCheck();
            ColumnsCheck();
            //DrawForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (currentPlayer == 1)
            {
                values[0, 2] = 1;
                button3.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                values[0, 2] = 2;
                button3.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
            RowsCheck();
            ColumnsCheck();
            //DrawForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (currentPlayer == 1)
            {
                values[1, 0] = 1;
                button4.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                values[1, 0] = 2;
                button4.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
            RowsCheck();
            ColumnsCheck();
            //DrawForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (currentPlayer == 1)
            {
                values[1, 1] = 1;
                button5.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                values[1, 1] = 2;
                button5.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
            RowsCheck();
            ColumnsCheck();
            //DrawForm();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (currentPlayer == 1)
            {
                values[1, 2] = 1;
                button6.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                values[1, 2] = 2;
                button6.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
            RowsCheck();
            ColumnsCheck();
            //DrawForm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            if (currentPlayer == 1)
            {
                values[2, 0] = 1;
                button7.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                values[2, 0] = 2;
                button7.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
            RowsCheck();
            ColumnsCheck();
            //DrawForm();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (currentPlayer == 1)
            {
                values[2, 1] = 1;
                button8.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                values[2, 1] = 2;
                button8.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
            RowsCheck();
            ColumnsCheck();
            //DrawForm();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            if (currentPlayer == 1)
            {
                values[2, 2] = 1;
                button9.Text = "X";
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                values[2, 2] = 2;
                button9.Text = "O";
                currentPlayer = 1;
            }
            DiagonalsCheck();
            RowsCheck();
            ColumnsCheck();
            //DrawForm();
        }

        internal class Prompt
        {
            public string ShowDialog(string title, string content)
            {
                Form prompt = new Form()
                {
                    Width = 350,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = title,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label label = new Label() { Left = 50, Top = 20, Text = content };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
                Button okButton = new Button() { Text = "OK", Left = 50, Width = 200, Top = 80, DialogResult = DialogResult.OK };
                okButton.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(label);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(okButton);
                prompt.AcceptButton = okButton;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }
    }
}

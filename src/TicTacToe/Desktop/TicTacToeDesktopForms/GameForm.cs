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
        public GameForm()
        {
            InitializeComponent();
            PlayerOneScoreLabel.Text = $"{m.ScoreX}";
            PlayerTwoScoreLabel.Text = $"{m.ScoreO}";
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
        }
    }
}

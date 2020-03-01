using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeDesktopForms
{
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            InitializeComponent();
            howLabel.Text = "1. Znajdź gracza do wspólnej rozgrywki";
            howLabel1.Text = "2. Rywalizujcie i powodzenia :)";
        }
    }
}

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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            aboutLabel.Text = "Gra kólko i krzyżyk stworzona do zabawy oraz portfolio :)";
            aboutLabel1.Text = "Autor: Sebastian Tyralski";
            aboutLabel2.Text = "Wersja: 2.0";
        }
    }
}

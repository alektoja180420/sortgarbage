using SortGarbage.Controllers;
using SortGarbage.Views;
using SortGarbage.Views.Dialogs;
using SortGarbage.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortGarbage
{
    /// <summary>
    /// Okienko menu
    /// </summary>
    public partial class Main : Form, IMainMenuView
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            var usernameDialog = new UsernameDialog(this);
            usernameDialog.Show();
        }

        private void ButtonScores_Click(object sender, EventArgs e)
        {
            var highScoresView = new HighScoresView();
            highScoresView.Show();
        }

        private void ButtonEndGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

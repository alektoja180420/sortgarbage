using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortGarbage.Views.Dialogs
{
    public partial class UsernameDialog : Form
    {
        private string playerName;

        public UsernameDialog()
        {
            InitializeComponent();
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text.Length > 0)
                this.playerName = UsernameTextbox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ShouldStartGame())
            {
                var gameView = new GameView(playerName);
                gameView.Show();
            }
            else
            {
                MessageBox.Show("Twoj nick powinien zawierac co najmniej 3 litery");
            }
        }
        
        private bool ShouldStartGame()
        {
            return UsernameTextbox.Text.Length >= 3;
        }
    }
}

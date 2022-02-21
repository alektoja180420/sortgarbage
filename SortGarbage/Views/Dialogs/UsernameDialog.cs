using SortGarbage.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace SortGarbage.Views.Dialogs
{
    /// <summary>
    /// Okienko do wpisania nazwy gracza
    /// </summary>
    public partial class UsernameDialog : Form
    {
        private string playerName;
        private IMainMenuView mainMenuReference;
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="mainMenu">Referencja do menu glownego</param>
        public UsernameDialog(IMainMenuView mainMenu)
        {
            InitializeComponent();
            mainMenuReference = mainMenu;
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
                mainMenuReference.Hide();
                this.Close();
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

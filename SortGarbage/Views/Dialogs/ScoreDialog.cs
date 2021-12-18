using SortGarbage.Models.GameModels;
using SortGarbage.Persistence.Repositories;
using SortGarbage.Services;
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
    public partial class ScoreDialog : Form
    {
        private readonly FinalScore _finalScore;
        private HighScoreService _highScoreService;
        private string _userName;
        
        public ScoreDialog(FinalScore finalScore, string userName)
        {
            InitializeComponent();
            _finalScore = finalScore;
            _userName = userName;
            _highScoreService = new HighScoreService(HighScoreRepositoryMock.GetInstance());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _highScoreService.AddHighScore(_userName, _finalScore.TotalScore);
            ReturnToMainMenu();
        }

        private void ScoreDialog_Load(object sender, EventArgs e)
        {
            totalScoreLabel.Text = $"Wynik: {_finalScore.TotalScore}";
            totalMovesLabel.Text = $"Ruchy: {_finalScore.MovesCounter}";
            totalTimeLabel.Text = $"Czas: {_finalScore.TotalGameTime}";
            label1.Text = $"{_userName} gratulacje!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void ReturnToMainMenu()
        {
            var mainMenu = new Main();
            mainMenu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

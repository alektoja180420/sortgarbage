using SortGarbage.Controllers;
using SortGarbage.Models.GameModels;
using SortGarbage.Views.CustomControls;
using SortGarbage.Views.Dialogs;
using SortGarbage.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SortGarbage.Views
{
    /// <summary>
    /// Okienko gry
    /// </summary>
    public partial class GameView : Form, IGameView
    {
        private GameController gameController;
        private ContainerPictureBox glassPictureBox;
        private ContainerPictureBox bioPictureBox;
        private ContainerPictureBox paperPictureBox;
        private ContainerPictureBox plasticPictureBox;
        private string playerName;
        private List<ContainerPictureBox> containers; 
        
        /// <summary>
        /// Kontenery na smieci
        /// </summary>
        public List<ContainerPictureBox> containerPictureBoxes { get { return containers; } set { containerPictureBoxes = value; } }
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="playerName">Nazwa gracza</param>
        public GameView(string playerName)
        {
            InitializeComponent();
            this.playerName = playerName;
            gameController = new GameController(this);
            InitializePictureBoxes();
        }
        /// <summary>
        /// Metoda odswiezajaca obrazki smieci
        /// </summary>
        public override void Refresh()
        {
            base.Refresh();
            Invalidate();
        }
        /// <summary>
        /// Metoda uaktualniajaca wynik
        /// </summary>
        /// <param name="score">Wynik</param>
        public void UpdateScore(int score)
        {
            scoreLabel.Text = $"Score: {score}";
        }
        /// <summary>
        /// Metoda konczaca gre
        /// </summary>
        /// <param name="finalScore">Wynik koncowy</param>
        public void FinishGame(FinalScore finalScore)
        {
            var scoreDialog = new ScoreDialog(finalScore, playerName);
            scoreDialog.Show();
            Close();
        }
        /// <summary>
        /// Metoda uaktualniajaca ilosc ruchow
        /// </summary>
        /// <param name="moveCounter">Liczba ruchow</param>
        public void UpdateMoveCounter(int moveCounter)
        {
            movesLabel.Text = $"Ruchy: {moveCounter}";
        }
        private void GameView_Load(object sender, EventArgs e)
        {
            gameController.StartGame();
            userNameLabel.Text = playerName;
            gameController.AssignNewGarbage(ref garbageButton1);
            gameController.AssignNewGarbage(ref garbageButton2);
            gameController.AssignNewGarbage(ref garbageButton3);
            gameController.AssignNewGarbage(ref garbageButton4);
            gameController.AssignNewGarbage(ref garbageButton5);
        }

        private void InitializePictureBoxes()
        {
            containers = new List<ContainerPictureBox>();

            glassPictureBox = new ContainerPictureBox(GlassContainerPictureBox, Models.Enums.GarbageType.Glass);
            bioPictureBox = new ContainerPictureBox(BioContainerPictureBox, Models.Enums.GarbageType.Bio);
            paperPictureBox = new ContainerPictureBox(PaperContainerPictureBox, Models.Enums.GarbageType.Paper);
            plasticPictureBox = new ContainerPictureBox(PlasticContainerPictureBox, Models.Enums.GarbageType.Plastic);

            containers.Add(glassPictureBox);
            containers.Add(bioPictureBox);
            containers.Add(paperPictureBox);
            containers.Add(plasticPictureBox);
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            gameController.OnGameFinished();
        }

        private void PerformActionWhenContainerSelected(GarbageButton button, bool properContainerSelected)
        {
            if (properContainerSelected)
            {
                RefreshButton(button);
            }
            else
            {
                BackButton(button);
            }
        }

        private void RefreshButton(GarbageButton button)
        {
            gameController.AssignNewGarbage(ref button);
            BackButton(button);
        }

        private void BackButton(GarbageButton button)
        {
            button.Location = button.DefaultLocation;
        }

        private void garbageButton1_MouseUp(object sender, MouseEventArgs e)
        {
            var containerSelected = gameController.OnContainerSelected(garbageButton1.AssignedGarbage, garbageButton1.Location);
            PerformActionWhenContainerSelected(garbageButton1, containerSelected);
        }

        private void garbageButton2_MouseUp(object sender, MouseEventArgs e)
        {
            var containerSelected = gameController.OnContainerSelected(garbageButton2.AssignedGarbage, garbageButton2.Location);
            PerformActionWhenContainerSelected(garbageButton2, containerSelected);
        }

        private void garbageButton3_MouseUp(object sender, MouseEventArgs e)
        {
            var containerSelected = gameController.OnContainerSelected(garbageButton3.AssignedGarbage, garbageButton3.Location);
            PerformActionWhenContainerSelected(garbageButton3, containerSelected);
        }

        private void garbageButton4_MouseUp(object sender, MouseEventArgs e)
        {
            var containerSelected = gameController.OnContainerSelected(garbageButton4.AssignedGarbage, garbageButton4.Location);
            PerformActionWhenContainerSelected(garbageButton4, containerSelected);
        }

        private void garbageButton5_MouseUp(object sender, MouseEventArgs e)
        {
            var containerSelected = gameController.OnContainerSelected(garbageButton5.AssignedGarbage, garbageButton5.Location);
            PerformActionWhenContainerSelected(garbageButton5, containerSelected);
        }
    }
}

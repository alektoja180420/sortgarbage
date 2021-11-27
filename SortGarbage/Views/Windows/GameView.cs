using SortGarbage.Controllers;
using SortGarbage.Models.GameModels;
using SortGarbage.Views.CustomControls;
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

namespace SortGarbage.Views
{
    public partial class GameView : Form, IGameView
    {
        private GameController gameController;
        private ContainerPictureBox glassPictureBox; 

        public GameView()
        {
            InitializeComponent();
            gameController = new GameController(this);
            InitializePictureBoxes();
        }

        private void GameView_Load(object sender, EventArgs e)
        {
            gameController.StartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GlassButton_Click(object sender, EventArgs e)
        {
            var garbage = new Garbage
            {
                Name = "Butla specka",
                GarbageType = Models.Enums.GarbageType.Glass
            };

            if (glassPictureBox.IsValidContainer(garbage))
            {
                gameController.OnProperContainerSelected();
            }
            else
            {
                gameController.OnWrongContainerSelected();
            }

            //MessageBox.Show
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {

        }

        private void InitializePictureBoxes()
        {
            glassPictureBox = new ContainerPictureBox(GlassContainerPictureBox, Models.Enums.GarbageType.Glass);
        }
    }
}

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
        private ContainerPictureBox bioPictureBox;
        private ContainerPictureBox paperPictureBox;
        private ContainerPictureBox plasticPictureBox;

        private List<ContainerPictureBox> containers;

        public List<ContainerPictureBox> containerPictureBoxes { get { return containers; } set { this.containerPictureBoxes = value; } }

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

        private void garbageButton1_Click(object sender, EventArgs e)
        {

        }

        public void ShowDummyDialog(string message)
        {
            MessageBox.Show(message);
        }

        private void garbageButton1_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(garbageButton1.Location);
        }

        private void BioContainerPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void PaperContainerPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void garbageButton2_Click(object sender, EventArgs e)
        {

        }

        private void garbageButton2_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(garbageButton2.Location);
        }
    }
}

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button3.Location);
        }



        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button33_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button33.Location);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button4.Location);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button5.Location);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button6.Location);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button8.Location);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button7.Location);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button2.Location);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button9.Location);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            gameController.OnContainerSelected(button10.Location);
        }
    }
}

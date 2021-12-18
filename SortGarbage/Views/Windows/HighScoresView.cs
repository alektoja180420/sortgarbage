using SortGarbage.Controllers;
using SortGarbage.Models.Entities;
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
    public partial class HighScoresView : Form, IHighScoresView
    {
        private HighScoresController _highScoresController;
        public HighScoresView()
        {
            InitializeComponent();
            _highScoresController = new HighScoresController(this);
        }

        public void AttachHighScores(List<HighScoreEntity> highScores)
        {
            dataGridView1.DataSource = highScores;
        }

        private void HighScoresView_Load(object sender, EventArgs e)
        {
            _highScoresController.PopulateHighScores();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

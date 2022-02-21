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
    /// <summary>
    /// Okienko najlepszych wynikow
    /// </summary>
    public partial class HighScoresView : Form, IHighScoresView
    {
        private HighScoresController _highScoresController;
        /// <summary>
        /// Konstruktor
        /// </summary>
        public HighScoresView()
        {
            InitializeComponent();
            _highScoresController = new HighScoresController(this);
        }
        /// <summary>
        /// Metoda wyswietlajaca wyniki
        /// </summary>
        /// <param name="highScores">Wynik</param>
        public void AttachHighScores(List<HighScoreEntity> highScores)
        {
            dataGridView1.DataSource = highScores;
        }
       
        private void HighScoresView_Load(object sender, EventArgs e)
        {
            _highScoresController.PopulateHighScores();
        }

    }
}

using SortGarbage.Persistence.Repositories;
using SortGarbage.Services;
using SortGarbage.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Controllers
{
    /// <summary>
    /// Klasa sluzaca do obslugi widoku najlepszych wynikow
    /// </summary>
    public class HighScoresController
    {
        private IHighScoresView _highScoresView;
        private HighScoreService _highScoreService;
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="highScoresView">Interfejs widoku</param>
        public HighScoresController(IHighScoresView highScoresView)
        {
            _highScoresView = highScoresView;
            _highScoreService = new HighScoreService(new HighScoresRepository());
        }
        /// <summary>
        /// Metoda przekazujaca do widoku informacje o najlepszych wynikach
        /// </summary>
        public void PopulateHighScores()
        {
            var values = _highScoreService.GetHighScoreEntities();
            _highScoresView.AttachHighScores(values);
        }


    }
}

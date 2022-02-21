using SortGarbage.Models.Entities;
using SortGarbage.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Services
{
    /// <summary>
    /// Serwis obsugujący dane najlepszych wyników
    /// </summary>
    public class HighScoreService
    {
        private readonly IHighScoreRepository _highScoreRepository;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="highScoreRepository">Sciezka do repozytorium najlepszych wynikow</param>
        public HighScoreService(IHighScoreRepository highScoreRepository)
        {
            _highScoreRepository = highScoreRepository;
        }

        /// <summary>
        /// Otrzymujemy wszystkie wyniki z bazy danych
        /// </summary>
        /// <returns>Wszystkie najlepsze wyniki z bazy danych</returns>
        public List<HighScoreEntity> GetHighScoreEntities()
        {
            return _highScoreRepository.GetHighScores();
        }

        /// <summary>
        /// Dodajemy nowy wynik do bazy
        /// </summary>
        /// <param name="userName">Nazwa gracza</param>
        /// <param name="points">Punkty</param>
        public void AddHighScore(string userName, int points)
        {
            var newHighScore = new HighScoreEntity
            {
                UserName = userName,
                Score = points
            };

            _highScoreRepository.AddHighScore(newHighScore);
        }


    }
}

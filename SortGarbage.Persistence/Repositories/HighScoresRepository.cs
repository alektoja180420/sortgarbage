using Newtonsoft.Json;
using SortGarbage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Persistence.Repositories
{
    /// <summary>
    /// Klasa nawiazujaca polaczenie z baza danych najlepszych wynikow
    /// </summary>
    public class HighScoresRepository : IHighScoreRepository
    {
        private List<HighScoreEntity> _highScores;
        private readonly string _fileName = "highscores.json";

        /// <summary>
        /// Konstruktor
        /// </summary>
        public HighScoresRepository()
        {
            _highScores = new List<HighScoreEntity>();
            GetFromDatabase();
        }

        /// <summary>
        /// Otrzymujemy najlepsze wyniki z bazy danych
        /// </summary>
        /// <returns>Otrzymujemy najlepsze wyniki z bazy danych</returns>
        public List<HighScoreEntity> GetHighScores()
        {
            GetFromDatabase();
            return _highScores;
        }

        /// <summary>
        /// Dodajemy nowy najlepszy wynik do bazy danych
        /// </summary>
        /// <param name="entity">Model bazodanowy najlepsze wyniku</param>
        public void AddHighScore(HighScoreEntity entity)
        {
            _highScores.Add(entity);
            Save();
        }

        private void Save()
        {
            string json = JsonConvert.SerializeObject(_highScores);
            File.WriteAllText(_fileName, json);
        }

        private void GetFromDatabase()
        {
            string jsonString = File.ReadAllText(_fileName);
            var highScores = JsonConvert.DeserializeObject<List<HighScoreEntity>>(jsonString);
            _highScores = highScores;
        }
        
    }
}

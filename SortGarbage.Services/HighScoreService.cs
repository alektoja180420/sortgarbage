using SortGarbage.Models.Entities;
using SortGarbage.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Services
{
    public class HighScoreService
    {
        private readonly IHighScoreRepository _highScoreRepository;

        public HighScoreService(IHighScoreRepository highScoreRepository)
        {
            _highScoreRepository = highScoreRepository;
        }

        public List<HighScoreEntity> GetHighScoreEntities()
        {
            return _highScoreRepository.GetHighScores();
        }

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

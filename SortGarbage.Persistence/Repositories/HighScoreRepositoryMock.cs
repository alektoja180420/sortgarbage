using SortGarbage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Persistence.Repositories
{
    public class HighScoreRepositoryMock : IHighScoreRepository
    {
        private static IHighScoreRepository _instance = null;
        public List<HighScoreEntity> HighScores { get; set; }

        private HighScoreRepositoryMock()
        {
            HighScores = new List<HighScoreEntity>();
            HighScores.Add(new HighScoreEntity() { UserName = "Alek", Score = 100 });
            HighScores.Add(new HighScoreEntity() { UserName= "Krakus", Score = 90 });
        }

        public static IHighScoreRepository GetInstance()
        {
            if(_instance == null)
            {
                _instance = new HighScoreRepositoryMock();
                return _instance;
            }
            return _instance;
        }

        public void AddHighScore(HighScoreEntity entity)
        {
            HighScores.Add(entity);
        }

        public List<HighScoreEntity> GetHighScores()
        {
            return HighScores;
        }
    }
}

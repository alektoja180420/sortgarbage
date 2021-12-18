using SortGarbage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Persistence.Repositories
{
    public interface IHighScoreRepository
    {
        public List<HighScoreEntity> GetHighScores();
        public void AddHighScore(HighScoreEntity entity);
    }
}

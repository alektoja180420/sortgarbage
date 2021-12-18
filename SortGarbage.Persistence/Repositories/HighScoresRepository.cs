using SortGarbage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Persistence.Repositories
{
    public class HighScoresRepository : IHighScoreRepository
    {
        private SqlConnection _sqlConnection;
        
        public HighScoresRepository()
        {
            _sqlConnection = new SqlConnection();
        }

        public List<HighScoreEntity> GetHighScores()
        {
            return new List<HighScoreEntity>();
        }

        public void AddHighScore(HighScoreEntity entity)
        {

        }
        
    }
}

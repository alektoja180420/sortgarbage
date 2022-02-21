using SortGarbage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Views.Interfaces
{
    /// <summary>
    /// Interfejs do okienka wynikow
    /// </summary>
    public interface IHighScoresView
    {
        public void AttachHighScores(List<HighScoreEntity> highScores);
    }
}

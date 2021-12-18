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
    public class HighScoresController
    {
        private IHighScoresView _highScoresView;
        private HighScoreService _highScoreService;

        public HighScoresController(IHighScoresView highScoresView)
        {
            _highScoresView = highScoresView;
            _highScoreService = new HighScoreService(HighScoreRepositoryMock.GetInstance());
        }

        public void PopulateHighScores()
        {
            var values = _highScoreService.GetHighScoreEntities();
            _highScoresView.AttachHighScores(values);
        }


    }
}

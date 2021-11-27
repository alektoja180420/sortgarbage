using SortGarbage.Models.GameModels;
using SortGarbage.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Controllers
{
    public class GameController
    {
        private IGameView _gameView;
        private GameProgress _gameProgress;
        private string tempPlayerName = "alektoja";
        public GameController(IGameView gameView)
        {
            _gameView = gameView;
        }

        public void StartGame()
        {
            _gameProgress = new GameProgress(tempPlayerName);
        }

        public void OnProperContainerSelected()
        {
            _gameProgress.IncreaseScore(10);
            _gameProgress.IncreaseMoveCounter();
        }

        public void OnWrongContainerSelected()
        {
            _gameProgress.DecreaseScore(10);
            _gameProgress.IncreaseMoveCounter();
        }

        public FinalScore OnGameFinished()
        {
            return new FinalScore
            {
                MovesCounter = _gameProgress.MovesCounter,
                TotalGameTime = _gameProgress.GetGameTime(),
                TotalScore = _gameProgress.TotalScore
            };
        }
    }
}

using SortGarbage.Models.GameModels;
using SortGarbage.Views.CustomControls;
using SortGarbage.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void OnContainerSelected(Point point)
        {
            IncreaseMoveCounter();
            foreach (var container in _gameView.containerPictureBoxes)
            {
                if (container.ElementTouchedContainer(point))
                {
                    _gameView.ShowDummyDialog($"dotknal {container.GarbageType}");
                }
            }
        }

        public void IncreaseMoveCounter()
        {
            _gameProgress.IncreaseMoveCounter();
            _gameView.UpdateMoveCounter(_gameProgress.MovesCounter);
        }

        public void OnProperContainerSelected()
        {
            _gameProgress.IncreaseScore(10);
            _gameProgress.IncreaseMoveCounter();
            _gameView.UpdateScore(_gameProgress.TotalScore);
        }

        public void OnWrongContainerSelected()
        {
            _gameProgress.DecreaseScore(10);
            _gameProgress.IncreaseMoveCounter();
            _gameView.UpdateScore(_gameProgress.TotalScore);
        }

        public void OnGameFinished()
        {
            var finalScore = new FinalScore
            {
                MovesCounter = _gameProgress.MovesCounter,
                TotalGameTime = _gameProgress.GetGameTime(),
                TotalScore = _gameProgress.TotalScore
            };
            _gameView.FinishGame(finalScore);
        }
    }
}

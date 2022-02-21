using SortGarbage.Models.GameModels;
using SortGarbage.Persistence.Repositories;
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
    /// <summary>
    /// Klasa sluzy do kontroli przebiegu gry
    /// </summary>
    
    public class GameController
    {
        private IGameView _gameView;
        private GameProgress _gameProgress;
        private string tempPlayerName = "alektoja";
        private readonly GarbageRepository _garbageRepository;
        private int numberOfGarbageThatHasToBeThrown = 10;

        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        /// <param name="gameView"> Interfejs widoku przebiegu gry</param>
        public GameController(IGameView gameView)
        {
            _gameView = gameView;
            _garbageRepository = new GarbageRepository();
        }

        /// <summary>
        /// Tworzy nowa instancje gry
        /// </summary>
        public void StartGame()
        {
            _gameProgress = new GameProgress(tempPlayerName);
        }

        /// <summary>
        /// Metoda wywoływana w przypadku wybrania kontenera na smieci
        /// </summary>
        /// <param name="garbage">Wrzucany smiec</param>
        /// <param name="point">Punkt dotkniecia</param>
        /// <returns></returns>
        public bool OnContainerSelected(Garbage garbage, Point point)
        {
            IncreaseMoveCounter();

            foreach (var container in _gameView.containerPictureBoxes)
            {
                if (container.ElementTouchedContainer(point))
                {
                    return ValidateContainer(garbage, container);
                }
            }

            return false;
        }
        /// <summary>
        /// Metoda wywołujaca zakonczenie gry
        /// </summary>
        public void OnGameFinished()
        {
            _gameProgress.DateEnd = DateTime.Now;
            var finalScore = new FinalScore
            {
                MovesCounter = _gameProgress.MovesCounter,
                TotalGameTime = _gameProgress.GetGameTime(),
                TotalScore = _gameProgress.TotalScore
            };
            _gameView.FinishGame(finalScore);
        }

        /// <summary>
        /// Metoda generyjaca smieci na ekranie
        /// </summary>
        /// <param name="garbageButton">Obiekt smiecia</param>
        public void AssignNewGarbage(ref GarbageButton garbageButton)
        {
            if (numberOfGarbageThatHasToBeThrown < 5)
            {
                garbageButton.Visible = false;
                return;
            }

            var garbage = _garbageRepository.GetRandomGarbage();
            garbageButton.AssignedGarbage = garbage;
            garbageButton.OnGarbageReassigned();
            _gameView.Refresh();
        }

        private void IncreaseMoveCounter()
        {
            _gameProgress.IncreaseMoveCounter();
            _gameView.UpdateMoveCounter(_gameProgress.MovesCounter);
        }

        private void OnProperContainerSelected()
        {
            numberOfGarbageThatHasToBeThrown--;

            _gameProgress.IncreaseScore(10);
            _gameView.UpdateScore(_gameProgress.TotalScore);

            if (numberOfGarbageThatHasToBeThrown == 0)
            {
                OnGameFinished();
            }
        }

        private void OnWrongContainerSelected()
        {
            _gameProgress.DecreaseScore(10);
            _gameView.UpdateScore(_gameProgress.TotalScore);
        }
        
        private bool ValidateContainer(Garbage garbage, ContainerPictureBox container)
        {
            if(IsContainerValid(garbage, container))
            {
                OnProperContainerSelected();
                return true;
            }
            else
            {
                OnWrongContainerSelected();
            }

            return false;
        }

        private bool IsContainerValid(Garbage garbage, ContainerPictureBox container)
        {
            return garbage.GarbageType == container.GarbageType;
        }
    }
}

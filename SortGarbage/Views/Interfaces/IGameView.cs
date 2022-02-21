using SortGarbage.Models.GameModels;
using SortGarbage.Views.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Views.Interfaces
{
    /// <summary>
    /// Interfejs do okienka gry
    /// </summary>
    public interface IGameView
    {
        List<ContainerPictureBox> containerPictureBoxes { get; set; }
        void Refresh();

        void UpdateScore(int score);

        void FinishGame(FinalScore finalScore);
        void UpdateMoveCounter(int moveCounter);
        //List<>
    }
}

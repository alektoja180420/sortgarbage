using SortGarbage.Models.GameModels;
using SortGarbage.Views.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Views.Interfaces
{
    public interface IGameView
    {
        List<ContainerPictureBox> containerPictureBoxes { get; set; }
        void ShowDummyDialog(string message);

        void UpdateScore(int score);

        void FinishGame(FinalScore finalScore);
        void UpdateMoveCounter(int moveCounter);
        //List<>
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Models.GameModels
{
    public class GameProgress
    {
        public Guid Id { get; set; }
        public string Player { get; set; }
        public int TotalScore { get; set; }
        public int MovesCounter { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public GameProgress()
        {
            AssignDefaultValues();
            Player = "Unknown";
        }

        public GameProgress(string player)
        {
            AssignDefaultValues();
            Player = player;
        }

        public int IncreaseScore(int value)
        {
            TotalScore += value;
            return TotalScore;
        }

        public int DecreaseScore(int value)
        {
            TotalScore -= value;
            return TotalScore;
        }

        public int IncreaseMoveCounter()
        {
            return ++MovesCounter;
        }

        public long GetGameTime()
        {
            return Math.Abs(DateStart.Ticks - DateEnd.Ticks);
        }

        private void AssignDefaultValues()
        {
            Id = Guid.NewGuid();
            TotalScore = 0;
            MovesCounter = 0;
            DateStart = DateTime.Now;
            DateEnd = DateTime.Now;
        }
    }
}

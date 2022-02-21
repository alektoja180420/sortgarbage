using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Models.GameModels
{
    /// <summary>
    /// Model opisujacy finalowy wynik gry
    /// </summary>
    public class FinalScore
    {
        /// <summary>
        /// Koncowy wynik
        /// </summary>
        public int TotalScore { get; set; }
        /// <summary>
        /// Liczba ruchow
        /// </summary>
        public int MovesCounter { get; set; }
        /// <summary>
        /// Czas gry w milisekundach
        /// </summary>
        public long TotalGameTime { get; set; }
    }
}

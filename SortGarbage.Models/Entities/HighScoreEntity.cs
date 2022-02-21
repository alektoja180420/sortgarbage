using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Models.Entities
{
    /// <summary>
    /// Model bazo danowy najlepszych wynikow
    /// </summary>
    public class HighScoreEntity
    {
        /// <summary>
        /// Nazwa gracza
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Wynik
        /// </summary>
        public int Score { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Models.GameModels
{
    /// <summary>
    /// Model, ktory gromadzi dane z przebiegu gry
    /// </summary>
    public class GameProgress
    {
        /// <summary>
        /// Identyfikator
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Nazwa gracza
        /// </summary>
        public string Player { get; set; }
        /// <summary>
        /// Aktualny wynik gracza
        /// </summary>
        public int TotalScore { get; set; }
        /// <summary>
        /// Aktualna liczba ruchow
        /// </summary>
        public int MovesCounter { get; set; }
        /// <summary>
        /// Godzina rozpocecia gry
        /// </summary>
        public DateTime DateStart { get; set; }
        /// <summary>
        /// Godzina zakonczenia gry
        /// </summary>
        public DateTime DateEnd { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public GameProgress()
        {
            AssignDefaultValues();
            Player = "Unknown";
        }
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="player">Nazwa gracza</param>
        public GameProgress(string player)
        {
            AssignDefaultValues();
            Player = player;
        }
        /// <summary>
        /// Metoda zwiekszajaca wynik
        /// </summary>
        /// <param name="value">Wartosc o ile zwiekszyc wynik</param>
        /// <returns></returns>
        public int IncreaseScore(int value)
        {
            TotalScore += value;
            return TotalScore;
        }
        /// <summary>
        /// Metoda zmniejszaca wynik
        /// </summary>
        /// <param name="value">Wartosc o ile zmniejszyc wynik</param>
        /// <returns></returns>
        public int DecreaseScore(int value)
        {
            TotalScore -= value;
            return TotalScore;
        }
        /// <summary>
        /// Metoda zwiekszajaca ilosc ruchow
        /// </summary>
        /// <returns>Zwraca ilosc ruchow powiekszona o jeden</returns>
        public int IncreaseMoveCounter()
        {
            return ++MovesCounter;
        }
        /// <summary>
        /// Metoda zwracajaca czas gry
        /// </summary>
        /// <returns>Zwraca koncowy czas gry w ms</returns>
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

using Newtonsoft.Json;
using SortGarbage.Models.GameModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Persistence.Repositories
{
    /// <summary>
    /// Klasa obsugujaca polaczenie z baza danych smieci
    /// </summary>
    public class GarbageRepository
    {
        private List<Garbage> garbages;
        /// <summary>
        /// Konstruktor
        /// </summary>
        public GarbageRepository()
        {
            garbages = new List<Garbage>();
            ConnectToGarbageDatabase();
        }
          /// <summary>
          /// Metoda pobierajaca losową wartosc smiecia z bazy danych
          /// </summary>
          /// <returns>smiec</returns>
        public Garbage GetRandomGarbage()
        {
            var random = new Random();
            var index = random.Next(garbages.Count);
            return garbages[index];
        }

        private void ConnectToGarbageDatabase()
        {
            string fileName = "smieci.json";
            string jsonString = File.ReadAllText(fileName);
            var garbage = JsonConvert.DeserializeObject<List<Garbage>>(jsonString);
            garbages = garbage;
        }
    }
}

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
    public class GarbageRepository
    {
        public List<Garbage> garbages;

        public GarbageRepository()
        {
            garbages = new List<Garbage>();
            ConnectToGarbageDatabase();
        }

        public List<Garbage> GetGarbages() { return garbages; }
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

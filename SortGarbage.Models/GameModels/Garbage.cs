using SortGarbage.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Models.GameModels
{
    public class Garbage
    {
        public string Path { get; set; }
        public GarbageType GarbageType { get; set; }
        public string GarbageName { get; set; }
    }
}

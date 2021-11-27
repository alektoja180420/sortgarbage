using SortGarbage.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Models.Entities
{
    public class GarbageEntity
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GarbageType Type { get; set; }
        public int Points { get; set; }
    }
}

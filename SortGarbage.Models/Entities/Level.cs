using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Models.Entities
{
    public class Level
    {
        public Guid Id { get; set; }
        public List<GarbageEntity> GarbageList { get; set; }


    }
}

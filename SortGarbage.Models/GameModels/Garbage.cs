using SortGarbage.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Models.GameModels
{
    /// <summary>
    /// Model smiecia
    /// </summary>
    public class Garbage
    {
        /// <summary>
        /// Sciezka do obrazka
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Typ smiecia
        /// </summary>
        public GarbageType GarbageType { get; set; }
        /// <summary>
        /// Nazwa smiecia
        /// </summary>
        public string GarbageName { get; set; }
    }
}

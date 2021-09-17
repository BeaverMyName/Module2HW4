using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models
{
    public abstract class Animal : ICloneable
    {
        public string Name { get; init; }
        public double Weight { get; set; }
        public UnitWeight UnitWeight { get; set; }
        public abstract CoveringType CoveringType { get; }
        public abstract int LegsAmount { get; }
        public abstract bool IsHasSpine { get; }

        public abstract object Clone();
    }
}

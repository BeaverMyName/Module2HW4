using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords
{
    public class Fish : Chord
    {
        public Fish(CoveringType coveringType)
        {
            CoveringType = coveringType;
        }

        public override int LegsAmount => 0;
        public override CoveringType CoveringType { get; }

        public override object Clone()
        {
            return new Fish(CoveringType) { Name = Name, Weight = Weight, UnitWeight = UnitWeight };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals.Mammals
{
    public class Deer : Mammal
    {
        public DeerType DeerType { get; init; }
        public override MammalType MammalType => MammalType.Placental;
        public override CoveringType CoveringType => CoveringType.Wool;

        public override object Clone()
        {
            return new Deer() { Weight = Weight, Name = Name, DeerType = DeerType, UnitWeight = UnitWeight };
        }
    }
}

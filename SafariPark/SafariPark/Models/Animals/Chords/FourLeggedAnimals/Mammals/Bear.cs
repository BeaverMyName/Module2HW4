using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals.Mammals
{
    public class Bear : Mammal
    {
        public BearType BearType { get; init; }
        public override MammalType MammalType => MammalType.Placental;
        public override CoveringType CoveringType => CoveringType.Wool;

        public override object Clone()
        {
            return new Bear() { Weight = Weight, Name = Name, BearType = BearType, UnitWeight = UnitWeight };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals.Mammals
{
    public class Platypus : Mammal
    {
        public override CoveringType CoveringType => CoveringType.Wool;
        public override MammalType MammalType => MammalType.Monotreme;

        public override object Clone()
        {
            return new Platypus() { Name = Name, Weight = Weight, UnitWeight = UnitWeight };
        }
    }
}

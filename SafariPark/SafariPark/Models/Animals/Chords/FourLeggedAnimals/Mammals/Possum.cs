using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals.Mammals
{
    public class Possum : Mammal
    {
        public override CoveringType CoveringType => CoveringType.Wool;
        public override MammalType MammalType => MammalType.Marsupial;

        public override object Clone()
        {
            return new Possum() { Name = Name, Weight = Weight, UnitWeight = UnitWeight };
        }
    }
}

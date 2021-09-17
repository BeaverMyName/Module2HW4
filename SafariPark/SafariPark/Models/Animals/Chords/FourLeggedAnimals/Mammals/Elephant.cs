using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals.Mammals
{
    public class Elephant : Mammal
    {
        public ElephantType ElephantType { get; init; }

        public override CoveringType CoveringType => CoveringType.Nothing;
        public override MammalType MammalType => MammalType.Placental;

        public override object Clone()
        {
            return new Elephant() { ElephantType = ElephantType, Name = Name, Weight = Weight, UnitWeight = UnitWeight };
        }
    }
}

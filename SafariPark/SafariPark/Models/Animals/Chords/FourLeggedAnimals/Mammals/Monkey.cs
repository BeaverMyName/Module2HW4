using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals.Mammals
{
    public class Monkey : Mammal
    {
        public MonkeyType MonkeyType { get; init; }

        public override CoveringType CoveringType => CoveringType.Wool;
        public override MammalType MammalType => MammalType.Placental;

        public override object Clone()
        {
            return new Monkey() { MonkeyType = MonkeyType, Name = Name, Weight = Weight, UnitWeight = UnitWeight };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals
{
    public class Bird : FourLegged
    {
        public BeakType BeakType { get; init; }
        public override CoveringType CoveringType => CoveringType.Feather;

        public override object Clone()
        {
            return new Bird() { BeakType = BeakType, Name = Name, Weight = Weight, UnitWeight = UnitWeight };
        }
    }
}

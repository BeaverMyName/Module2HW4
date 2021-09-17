using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals
{
    public class Amphibia : FourLegged
    {
        public AmphibiaType AmphibiaType { get; init; }
        public override CoveringType CoveringType => CoveringType.Nothing;

        public override object Clone()
        {
            return new Amphibia() { Name = Name, Weight = Weight, AmphibiaType = AmphibiaType, UnitWeight = UnitWeight };
        }
    }
}

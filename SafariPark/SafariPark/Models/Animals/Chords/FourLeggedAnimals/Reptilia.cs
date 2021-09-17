using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals
{
    public class Reptilia : FourLegged
    {
        public ReptiliaType ReptiliaType { get; init; }
        public override CoveringType CoveringType
        {
            get
            {
                if (ReptiliaType == ReptiliaType.Scaly)
                {
                    return CoveringType.Scale;
                }
                else
                {
                    return CoveringType.Nothing;
                }
            }
        }

        public override object Clone()
        {
            return new Reptilia() { Weight = Weight, Name = Name, ReptiliaType = ReptiliaType, UnitWeight = UnitWeight };
        }
    }
}

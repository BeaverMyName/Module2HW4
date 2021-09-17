using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals.Chords.FourLeggedAnimals
{
    public abstract class Mammal : FourLegged
    {
        public abstract MammalType MammalType { get; }
    }
}

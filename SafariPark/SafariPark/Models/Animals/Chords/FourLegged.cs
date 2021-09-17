using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models.Animals.Chords
{
    public abstract class FourLegged : Chord
    {
        public override int LegsAmount => 4;
    }
}

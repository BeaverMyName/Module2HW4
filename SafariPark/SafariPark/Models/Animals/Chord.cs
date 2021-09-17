using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models.Animals
{
    public abstract class Chord : Animal
    {
        public override bool IsHasSpine => true;
    }
}

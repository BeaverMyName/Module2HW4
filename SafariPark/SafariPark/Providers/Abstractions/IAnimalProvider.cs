using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;

namespace SafariPark.Providers.Abstractions
{
    public interface IAnimalProvider
    {
        public Animal[] Animals { get; }
    }
}

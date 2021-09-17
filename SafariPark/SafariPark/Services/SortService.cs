using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;
using SafariPark.Services.Abstractions;
using SafariPark.Extensions;

namespace SafariPark.Services
{
    public class SortService : ISortService
    {
        public void SortByWeight(Animal[] animals, IComparer comparer)
        {
            Array.Sort(animals, comparer);
        }
    }
}

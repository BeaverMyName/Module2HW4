using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;

namespace SafariPark.Services.Abstractions
{
    public interface ISortService
    {
        public void SortByWeight(Animal[] animals, IComparer comparer);
    }
}

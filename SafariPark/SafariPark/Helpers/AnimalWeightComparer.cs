using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;

namespace SafariPark.Helpers
{
    public class AnimalWeightComparer : IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            var animal1 = obj1 as Animal;
            var animal2 = obj2 as Animal;

            if (animal1.Weight > animal2.Weight)
            {
                return 1;
            }
            else if (animal1.Weight < animal2.Weight)
            {
                return -1;
            }

            return 0;
        }
    }
}

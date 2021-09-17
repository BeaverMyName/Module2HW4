using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;
using SafariPark.Services;

namespace SafariPark.Extensions
{
    public static class CageServiceExtension
    {
        public static Animal FindSpecificAnimal(this Animal[] animals, Type type)
        {
            foreach (var animal in animals)
            {
                if (animal.GetType() == type)
                {
                    return animal;
                }
            }

            return null;
        }
    }
}

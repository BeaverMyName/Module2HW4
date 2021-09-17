using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;
using SafariPark.Enums;

namespace SafariPark.Services.Abstractions
{
    public interface IAnimalWeightService
    {
        public void ConvertAnimalWeightToDefault(Animal animal);
        public UnitWeightData GetUnitWeightData(UnitWeight unitWeight);
    }
}

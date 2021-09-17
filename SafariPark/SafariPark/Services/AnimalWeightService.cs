using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Services.Abstractions;
using SafariPark.Enums;
using SafariPark.Models;

namespace SafariPark.Services
{
    public class AnimalWeightService : IAnimalWeightService
    {
        private readonly WeightConfig _weightConfig;

        public AnimalWeightService()
        {
            _weightConfig = ConfigService.Instance.WeightConfig;
        }

        public void ConvertAnimalWeightToDefault(Animal animal)
        {
            var rateCurrentToDefault = GetUnitWeightData(animal.UnitWeight).RateCurrentToDefault;
            animal.UnitWeight = _weightConfig.DefaultWeightUnit;
            animal.Weight *= rateCurrentToDefault;
        }

        public UnitWeightData GetUnitWeightData(UnitWeight unitWeight)
        {
            foreach (var unitWeightData in _weightConfig.WeightUnitDatas)
            {
                if (unitWeightData.UnitWeight == unitWeight)
                {
                    return unitWeightData;
                }
            }

            return null;
        }
    }
}

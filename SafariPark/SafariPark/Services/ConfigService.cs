using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Services.Abstractions;
using SafariPark.Models;
using SafariPark.Enums;

namespace SafariPark.Services
{
    public class ConfigService : IConfigService
    {
        private static readonly IConfigService _instance = new ConfigService();
        private readonly Config _config;

        static ConfigService()
        {
        }

        private ConfigService()
        {
            _config = new Config()
            {
                WeightConfig = new WeightConfig()
                {
                    WeightUnitDatas = new UnitWeightData[]
                    {
                        new UnitWeightData() { UnitWeight = UnitWeight.Gram, RateCurrentToDefault = 0.001 },
                        new UnitWeightData() { UnitWeight = UnitWeight.Kilogram, RateCurrentToDefault = 1 },
                        new UnitWeightData() { UnitWeight = UnitWeight.Ton, RateCurrentToDefault = 1000 }
                    },
                    DefaultWeightUnit = UnitWeight.Kilogram
                }
            };
        }

        public static IConfigService Instance => _instance;

        public Config Config => _config;

        public WeightConfig WeightConfig => _instance.Config.WeightConfig;
    }
}

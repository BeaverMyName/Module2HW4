using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;

namespace SafariPark.Services.Abstractions
{
    public interface IConfigService
    {
        public static ConfigService Instance { get; }
        public Config Config { get; }
        public WeightConfig WeightConfig { get; }
    }
}

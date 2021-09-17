using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SafariPark.Services.Abstractions;
using SafariPark.Services;
using SafariPark.Providers.Abstractions;
using SafariPark.Providers;

namespace SafariPark
{
    public class ApplicationStart
    {
        private Starter _starter;

        public void StartApplication()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IZooService, ZooService>()
                .AddTransient<ICageService, CageService>()
                .AddTransient<ISortService, SortService>()
                .AddTransient<IAnimalProvider, AnimalProvider>()
                .AddSingleton<IConfigService, ConfigService>()
                .AddTransient<IAnimalWeightService, AnimalWeightService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            _starter = serviceProvider.GetService<Starter>();
            _starter.Run();
        }
    }
}

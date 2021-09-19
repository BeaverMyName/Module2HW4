using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Extensions.DependencyInjection;
using SafariPark.Services.Abstractions;
using SafariPark.Services;
using SafariPark.Providers.Abstractions;
using SafariPark.Providers;
using SafariPark.Helpers;

namespace SafariPark
{
    public class Starter
    {
        private Application _application;

        public void StartApplication()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IZooService, ZooService>()
                .AddTransient<ICageService, CageService>()
                .AddTransient<ISortService, SortService>()
                .AddTransient<IAnimalProvider, AnimalProvider>()
                .AddSingleton<IConfigService, ConfigService>()
                .AddTransient<IComparer, Comparer>()
                .AddTransient<IAnimalWeightService, AnimalWeightService>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            _application = serviceProvider.GetService<Application>();
            _application.Run();
        }
    }
}

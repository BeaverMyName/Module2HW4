using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Services.Abstractions;
using SafariPark.Providers.Abstractions;

namespace SafariPark.Services
{
    public class ZooService : IZooService
    {
        private readonly IAnimalProvider _animalProvider;

        public ZooService(IAnimalProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public bool SetRandomAnimalsToCage(ICageService cageService, int amount)
        {
            var random = new Random();
            var animals = _animalProvider.Animals;

            if (amount < 1 || amount > cageService.Capacity)
            {
                return false;
            }
            else
            {
                for (var i = 0; i < amount; i++)
                {
                    cageService.Add(animals[random.Next(0, animals.Length)]);
                }

                return true;
            }
        }
    }
}

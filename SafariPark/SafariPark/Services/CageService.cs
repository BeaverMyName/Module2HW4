using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;
using SafariPark.Providers;
using SafariPark.Services.Abstractions;

namespace SafariPark.Services
{
    public class CageService : ICageService
    {
        private readonly IAnimalWeightService _animalWeightService;
        private Cage _cage;

        public CageService(IAnimalWeightService animalWeightService)
        {
            _animalWeightService = animalWeightService;
        }

        public int Capacity => _cage.Capacity;
        public int AnimalAmount => _cage.Animals.Length;
        public Cage Cage => _cage;

        public int AmountOfDifferentAnimals
        {
            get
            {
                var types = new Type[1] { _cage.Animals[0].GetType() };
                var match = false;

                for (var i = 1; i < AnimalAmount; i++)
                {
                    for (var j = 0; j < types.Length; j++)
                    {
                        if (_cage.Animals[i].GetType() == types[j])
                        {
                            match = true;
                        }
                    }

                    if (!match)
                    {
                        var oldTypes = types;
                        types = new Type[types.Length + 1];

                        for (var k = 0; k < oldTypes.Length; k++)
                        {
                            types[k] = oldTypes[k];
                        }

                        types[types.Length - 1] = _cage.Animals[i].GetType();
                    }
                    else
                    {
                        match = false;
                    }
                }

                return types.Length;
            }
        }

        public Cage CreateCage(int capacity, double square, double height)
        {
            if (capacity == 0 || square < 1)
            {
                throw new ArgumentException("Capacity must be more than 0. Square mustn't be less than 1.");
            }

            _cage = new Cage() { Capacity = capacity, Square = square, Height = height, Animals = new Animal[0] };
            return _cage;
        }

        public bool Add(Animal animal)
        {
            if (_cage == null || AnimalAmount >= Capacity)
            {
                return false;
            }
            else
            {
                _animalWeightService.ConvertAnimalWeightToDefault(animal);
                var animals = _cage.Animals;

                _cage.Animals = new Animal[AnimalAmount + 1];

                for (var i = 0; i < AnimalAmount - 1; i++)
                {
                    _cage.Animals[i] = animals[i];
                }

                _cage.Animals[AnimalAmount - 1] = animal;

                return true;
            }
        }

        public bool Remove(Animal animal)
        {
            _animalWeightService.ConvertAnimalWeightToDefault(animal);
            if (_cage == null || AnimalAmount == 0)
            {
                return false;
            }
            else
            {
                var animals = _cage.Animals;
                var step = 0;

                _cage.Animals = new Animal[AnimalAmount - 1];

                for (var i = 0; i < AnimalAmount + 1; i++)
                {
                    if (animals[i] == animal && step < 1)
                    {
                        step += 1;
                        continue;
                    }
                    else
                    {
                        _cage.Animals[i - step] = animals[i];
                    }
                }

                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Services.Abstractions;
using SafariPark.Helpers;
using SafariPark.Extensions;
using SafariPark.Models.Animals.Chords.FourLeggedAnimals.Mammals;
using SafariPark.Models;

namespace SafariPark
{
    public class Application
    {
        private readonly IZooService _zooService;
        private readonly ICageService _cageService;
        private readonly ISortService _sortService;
        private AnimalWeightComparer _animalWeightComparer;

        public Application(IZooService zooService, ICageService cageService, ISortService sortService)
        {
            _cageService = cageService;
            _sortService = sortService;
            _zooService = zooService;
            _animalWeightComparer = new AnimalWeightComparer();
        }

        public void Run()
        {
            _cageService.CreateCage(10, 100, 5);

            _zooService.SetRandomAnimalsToCage(_cageService, 10);

            DisplayAnimals(_cageService.Cage.Animals);

            var amountOfDifferentAnimals = _cageService.AmountOfDifferentAnimals;

            DisplayObject(amountOfDifferentAnimals);

            _sortService.SortByWeight(_cageService.Cage.Animals, _animalWeightComparer);

            DisplayAnimals(_cageService.Cage.Animals);

            var animal = _cageService.Cage.Animals.FindSpecificAnimal(typeof(Cat));

            if (animal != null)
            {
                DisplayObject(animal.Name);
            }
        }

        public void DisplayAnimals(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} : {animal.Weight} {animal.UnitWeight}");
            }

            DisplayIndent();
        }

        public void DisplayObject(object obj)
        {
            Console.WriteLine(obj);
            DisplayIndent();
        }

        public void DisplayIndent()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();
        }
    }
}

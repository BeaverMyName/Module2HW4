using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;
using SafariPark.Models.Animals;
using SafariPark.Providers.Abstractions;
using SafariPark.Enums;
using SafariPark.Models.Animals.Chords;
using SafariPark.Models.Animals.Chords.FourLeggedAnimals;
using SafariPark.Models.Animals.Chords.FourLeggedAnimals.Mammals;

namespace SafariPark.Providers
{
    public class AnimalProvider : IAnimalProvider
    {
        private readonly Animal[] _animals;

        public AnimalProvider()
        {
            _animals = new Animal[]
            {
                new Arthropod(8, CoveringType.Wool) { ArthropodType = ArthropodType.Arachnid, Name = "Tarantula", Weight = 150, UnitWeight = UnitWeight.Gram },
                new Fish(CoveringType.Scale) { Name = "Goldfish", Weight = 100, UnitWeight = UnitWeight.Gram },
                new Bird() { BeakType = BeakType.Predatory, Name = "Desert Eagle", Weight = 2, UnitWeight = UnitWeight.Kilogram },
                new Bird() { BeakType = BeakType.Water, Name = "Grey Duck", Weight = 1000, UnitWeight = UnitWeight.Gram },
                new Cat() { CatType = CatType.Tiger, Name = "White Tiger", Weight = 150, UnitWeight = UnitWeight.Kilogram },
                new Cat() { CatType = CatType.Lynx, Name = "Siberian Lynx", Weight = 30, UnitWeight = UnitWeight.Kilogram },
                new Bear() { BearType = BearType.Brown, Name = "Russian Brown Bear", Weight = 500, UnitWeight = UnitWeight.Kilogram },
                new Bear() { BearType = BearType.Polar, Name = "Artic Polar Bear", Weight = 350, UnitWeight = UnitWeight.Kilogram },
                new Bear() { BearType = BearType.GiantPanda, Name = "Giant Panda", Weight = 400, UnitWeight = UnitWeight.Kilogram },
                new Deer() { DeerType = DeerType.Alces, Name = "Elk", Weight = 100, UnitWeight = UnitWeight.Kilogram },
                new Monkey() { MonkeyType = MonkeyType.Gorilla, Name = "Gorilla", Weight = 200, UnitWeight = UnitWeight.Kilogram },
                new Monkey() { MonkeyType = MonkeyType.Chimpanzee, Name = "Chempanzee", Weight = 50, UnitWeight = UnitWeight.Kilogram },
                new Monkey() { MonkeyType = MonkeyType.Orangutan, Name = "Orangutan", Weight = 90, UnitWeight = UnitWeight.Kilogram },
                new Possum() { Name = "Possum", Weight = 1000, UnitWeight = UnitWeight.Gram },
                new Platypus() { Name = "Platypus", Weight = 2000, UnitWeight = UnitWeight.Gram },
                new Elephant() { ElephantType = ElephantType.Bush, Name = "Bush Elephant", Weight = 12, UnitWeight = UnitWeight.Ton },
                new Hippopotamus() { HippopotamusType = HippopotamusType.Common, Name = "Common Hippo", Weight = 3, UnitWeight = UnitWeight.Ton }
            };
        }

        public Animal[] Animals
        {
            get
            {
                var animals = new Animal[_animals.Length];
                for (var i = 0; i < _animals.Length; i++)
                {
                    animals[i] = _animals[i].Clone() as Animal;
                }

                return animals;
            }
        }
    }
}

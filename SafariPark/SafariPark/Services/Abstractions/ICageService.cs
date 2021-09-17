using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;
using SafariPark.Extensions;

namespace SafariPark.Services.Abstractions
{
    public interface ICageService
    {
        public int Capacity { get; }
        public int AnimalAmount { get; }
        public Cage Cage { get; }
        public int AmountOfDifferentAnimals { get; }

        public Cage CreateCage(int capacity, double square, double height);
        public bool Add(Animal animal);
        public bool Remove(Animal animal);
    }
}

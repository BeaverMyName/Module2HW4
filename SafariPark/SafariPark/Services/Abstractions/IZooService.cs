using SafariPark.Models;
using SafariPark.Services.Abstractions;

namespace SafariPark.Services.Abstractions
{
    public interface IZooService
    {
        public bool SetRandomAnimalsToCage(ICageService cageService, int amount);
    }
}

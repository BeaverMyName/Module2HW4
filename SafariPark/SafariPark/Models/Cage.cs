using System;

namespace SafariPark.Models
{
    public class Cage
    {
        public Animal[] Animals { get; set; }
        public int Capacity { get; init; }
        public double Square { get; init; }
        public double Height { get; init; }
    }
}

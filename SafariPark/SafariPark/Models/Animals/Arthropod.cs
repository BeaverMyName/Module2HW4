using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Enums;

namespace SafariPark.Models.Animals
{
    public class Arthropod : Animal
    {
        public Arthropod(int legsAmount, CoveringType coveringType)
        {
            LegsAmount = legsAmount;
            CoveringType = coveringType;
        }

        public ArthropodType ArthropodType { get; init; }
        public override CoveringType CoveringType { get; }
        public override int LegsAmount { get; }
        public override bool IsHasSpine { get; }

        public override object Clone()
        {
            return new Arthropod(LegsAmount, CoveringType) { Name = Name, Weight = Weight, ArthropodType = ArthropodType, UnitWeight = UnitWeight };
        }
    }
}

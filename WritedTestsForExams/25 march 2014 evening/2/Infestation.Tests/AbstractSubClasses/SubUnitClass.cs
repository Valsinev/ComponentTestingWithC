using System;

namespace Infestation.Tests.AbstractSubClasses
{
    public class SubUnitClass : Unit
    {
        public SubUnitClass(string id, UnitClassification unitType, int health, int power, int aggression) 
            : base(id, unitType, health, power, aggression)
        {
        }
    }
}

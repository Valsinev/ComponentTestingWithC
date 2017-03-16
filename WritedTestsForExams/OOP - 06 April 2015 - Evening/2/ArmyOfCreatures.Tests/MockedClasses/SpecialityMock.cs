using ArmyOfCreatures.Logic.Specialties;
using System;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreatures.Tests.MockedClasses
{
    public class SpecialityMock : Specialty
    {
        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
            base.ApplyWhenAttacking(attackerWithSpecialty, defender);
        }
    }
}

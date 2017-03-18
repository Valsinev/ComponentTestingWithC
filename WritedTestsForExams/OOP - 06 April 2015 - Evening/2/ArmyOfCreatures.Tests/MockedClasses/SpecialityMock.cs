namespace ArmyOfCreatures.Tests.MockedClasses
{
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    public class SpecialityMock : Specialty
    {
        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
            base.ApplyWhenAttacking(attackerWithSpecialty, defender);
        }
    }
}

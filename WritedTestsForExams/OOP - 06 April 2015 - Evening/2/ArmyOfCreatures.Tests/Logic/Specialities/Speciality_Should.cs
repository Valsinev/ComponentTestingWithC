using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Tests.MockedClasses;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Logic.Specialities
{
    [TestFixture]
    public class Speciality_Should
    {
        [Test]
        public void ReturnCorrectDamage_ChangeDamageWhenAttackingIsCalledWithoutHatedType()
        {
            var specialty = new SpecialityMock();

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            var result = specialty.ChangeDamageWhenAttacking(creaturesInBattle, creaturesInBattle, 10);

            Assert.AreEqual(10, result);
        }
    }
}

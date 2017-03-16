using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Logic.Specialities.HateTests
{
    [TestFixture]
    public class Hate_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenNullCreatureToHateIsPassed()
        {
            Assert.Throws<ArgumentNullException>(() => new Hate(null));
        }

        [Test]
        public void ReturnCorrectStringFormat_WhenToStringIsCalled()
        {
            var hate = new Hate(typeof(Angel));

            Assert.AreEqual("Hate(Angel)", hate.ToString());
        }

        [Test]
        public void ThrowArgumentNullException_ChangeDamageWhenAttackingIsCalledWithNullAttacker()
        {
            var hate = new Hate(typeof(Angel));

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() =>
                hate.ChangeDamageWhenAttacking(null, creaturesInBattle, 20));
        }

        [Test]
        public void ThrowArgumentNullException_ChangeDamageWhenAttackingIsCalledWithNullDefender()
        {
            var hate = new Hate(typeof(Angel));

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() =>
                hate.ChangeDamageWhenAttacking(creaturesInBattle, null, 20));
        }

        [Test]
        public void ReturnCorrectDamageWithBonusFromHate_ChangeDamageWhenAttackingIsCalledWithHatedType()
        {
            var hate = new Hate(typeof(Devil));

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);
            var creaturesInBattleDefend = new CreaturesInBattle(new Devil(), 1);
            
            var result = hate.ChangeDamageWhenAttacking(creaturesInBattle, creaturesInBattleDefend, 10);

            Assert.AreEqual(15, result);
        }

        [Test]
        public void ReturnCorrectDamage_ChangeDamageWhenAttackingIsCalledWithoutHatedType()
        {
            var hate = new Hate(typeof(Devil));

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            var result = hate.ChangeDamageWhenAttacking(creaturesInBattle, creaturesInBattle, 10);

            Assert.AreEqual(10, result);
        }
    }
}

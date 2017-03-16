using ArmyOfCreatures.Extended.Specialties;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Extended.DoubleDamageTests
{
    [TestFixture]
    public class DoubleDamage_Should
    {
        [TestCase(-1)]
        [TestCase(15)]
        public void ThrowArgumentOutOfRangeException_WhenOutOfRangeRoundsArePassed(int rounds)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new DoubleDamage(rounds));
        }

        [Test]
        public void ThrowArgumentNullException_WhenNullAttackerWithSpecialtyIsPassed()
        {
            var doubleDamage = new DoubleDamage(5);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() =>
                doubleDamage.ChangeDamageWhenAttacking(null, creaturesInBattle, 20));
        }

        [Test]
        public void ThrowArgumentNullException_WhenNullDefenderWithSpecialtyIsPassed()
        {
            var doubleDamage = new DoubleDamage(5);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() =>
                doubleDamage.ChangeDamageWhenAttacking(creaturesInBattle, null, 20));
        }

        [Test]
        public void ResetToCurrentDamage_WhenRoundsGoBellow1()
        {
            var doubleDamage = new DoubleDamage(1);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            var currentDamage = 2;

            doubleDamage.ChangeDamageWhenAttacking(creaturesInBattle, creaturesInBattle, currentDamage);
            var result = doubleDamage.ChangeDamageWhenAttacking(creaturesInBattle, creaturesInBattle, currentDamage);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void ReturnCorrectStringFormat_WhenToStringMethodIsCalled()
        {
            var doubleDamage = new DoubleDamage(1);

            Assert.AreEqual("DoubleDamage(1)", doubleDamage.ToString());
        }
    }
}

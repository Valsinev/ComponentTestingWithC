using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Logic.Specialities.AddDefenseWhenSkipTests
{
    [TestFixture]
    public class AddDefenseWhenSkip_Should
    {
        [TestCase(0)]
        [TestCase(21)]
        public void ThrowArgumentOutOfRangeException_WhenDefensePassedIsOutOfRange(int defense)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AddDefenseWhenSkip(defense));
        }

        [Test]
        public void ThrowArgumentNullException_ApplyOnSkipIsCalledWithNullCreature()
        {
            var defenceWhenSkip = new AddDefenseWhenSkip(2);

            Assert.Throws<ArgumentNullException>(() => defenceWhenSkip.ApplyOnSkip(null));
        }

        [Test]
        public void ReturnCorrectStringFormat_WhenToStringIsCalled()
        {
            var defenceWhenSkip = new AddDefenseWhenSkip(2);

            Assert.AreEqual("AddDefenseWhenSkip(2)", defenceWhenSkip.ToString());
        }

        [Test]
        public void ReturnCorrectPermanentDefense_WhenApplyOnSkipIsCalled()
        {
            var defenceWhenSkip = new AddDefenseWhenSkip(2);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            defenceWhenSkip.ApplyOnSkip(creaturesInBattle);

            Assert.AreEqual(22, creaturesInBattle.PermanentDefense);
        }
    }
}

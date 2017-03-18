namespace ArmyOfCreatures.Tests.Extended.AddAttackWhenSkipTests
{
    using System;

    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;
    using NUnit.Framework;

    [TestFixture]
    public class AddAttackWhenSkip_Should
    {
        [TestCase(0)]
        [TestCase(11)]
        public void ThrowArgumentOutOfRangeException_WhenInvalidRangeIsPassed(int range)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AddAttackWhenSkip(range));
        }

        [Test]
        public void ThrowArgumentNullException_NullSkipCreatureIsPassed()
        {
            var attackWhenSkip = new AddAttackWhenSkip(9);

            Assert.Throws<ArgumentNullException>(() => attackWhenSkip.ApplyOnSkip(null));
        }

        [Test]
        public void AddCorrectValue_SkipCreatureIsPassed()
        {
            var attackWhenSkip = new AddAttackWhenSkip(9);

            var creature = new Angel();

            var creaturesInBattle = new CreaturesInBattle(creature, 1);

            attackWhenSkip.ApplyOnSkip(creaturesInBattle);

            Assert.AreEqual(29, creaturesInBattle.PermanentAttack);
        }

        [Test]
        public void ReturnCorrectStringFormat_WhenToStringMethodIsCalled()
        {
            var attackWhenSkip = new AddAttackWhenSkip(9);

            Assert.AreEqual("AddAttackWhenSkip(9)", attackWhenSkip.ToString());
        }
    }
}

using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Logic.Specialities.DoubleDefenseWhenDefendingTests
{
    [TestFixture]
    public class DoubleDefenseWhenDefending_Should
    {
        [Test]
        public void ThrowArgumentOutOfRangeException_WhenBellow0RoundsArePassed()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new DoubleDefenseWhenDefending(0));
        }

        [Test]
        public void ThrowArgumentNullException_WhenApplyWhenDefendingIsCalledWithNullDefenderWithSpecialty()
        {
            var doubleDefenseWhenDefending = new DoubleDefenseWhenDefending(1);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() =>
                doubleDefenseWhenDefending.ApplyWhenDefending(null, creaturesInBattle));
        }

        [Test]
        public void ThrowArgumentNullException_WhenApplyWhenDefendingIsCalledWithNullAttackerWithSpecialty()
        {
            var doubleDefenseWhenDefending = new DoubleDefenseWhenDefending(1);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() =>
                doubleDefenseWhenDefending.ApplyWhenDefending(creaturesInBattle, null));
        }

        [Test]
        public void ReturnCorrectStringFormat_WhenToStringIsCalled()
        {
            var doubleDefenseWhenDefending = new DoubleDefenseWhenDefending(1);

            Assert.AreEqual("DoubleDefenseWhenDefending(1)", doubleDefenseWhenDefending.ToString());
        }

        [Test]
        public void ReturnCorrectMultipliedDefense_WhenApplyWhenDefendingIsCalled()
        {
            var doubleDefenseWhenDefending = new DoubleDefenseWhenDefending(1);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            doubleDefenseWhenDefending.ApplyWhenDefending(creaturesInBattle, creaturesInBattle);

            Assert.AreEqual(40, creaturesInBattle.CurrentDefense);
        }

        [Test]
        public void ResetCurrentDefense_WhenApplyWhenDefendingRoundsGetTo0()
        {
            var doubleDefenseWhenDefending = new DoubleDefenseWhenDefending(2);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            doubleDefenseWhenDefending.ApplyWhenDefending(creaturesInBattle, creaturesInBattle);
            doubleDefenseWhenDefending.ApplyWhenDefending(creaturesInBattle, creaturesInBattle);
            doubleDefenseWhenDefending.ApplyWhenDefending(creaturesInBattle, creaturesInBattle);

            Assert.AreEqual(80, creaturesInBattle.CurrentDefense);
        }
    }
}

﻿namespace ArmyOfCreatures.Tests.Logic.Specialities.ResurrectionTests
{
    using System;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;
    using NUnit.Framework;

    [TestFixture]
    public class Resurrection_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenApplyAfterDefendingIsCalledWithNullDefender()
        {
            var resurrection = new Resurrection();

            Assert.Throws<ArgumentNullException>(() => resurrection.ApplyAfterDefending(null));
        }

        [Test]
        public void ReturnCorrectTotalHitPoints_WhenApplyAfterDefendingIsCalled()
        {
            var resurrection = new Resurrection();

            var angel = new Angel();

            var creaturesInBattle = new CreaturesInBattle(angel, 1);

            resurrection.ApplyAfterDefending(creaturesInBattle);

            Assert.AreEqual(200, creaturesInBattle.TotalHitPoints);
        }
    }
}

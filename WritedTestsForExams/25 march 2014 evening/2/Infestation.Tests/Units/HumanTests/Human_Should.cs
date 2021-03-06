﻿namespace Infestation.Tests.Units.HumanTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Human_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var human = new Human("Pesho");

            Assert.IsInstanceOf(typeof(Human), human);
        }

        [Test]
        public void ReturnCorrectPowerValue_WhenProperyPowerIsCalled()
        {
            var human = new Human("Pesho");

            Assert.AreEqual(4, human.Power);
        }

        [Test]
        public void ReturnCorrectAggressionValue_WhenProperyAggressionIsCalled()
        {
            var human = new Human("Pesho");

            Assert.AreEqual(1, human.Aggression);
        }

        [Test]
        public void ReturnCorrectHealthValue_WhenProperyHealthIsCalled()
        {
            var human = new Human("Pesho");

            Assert.AreEqual(10, human.Health);
        }
    }
}

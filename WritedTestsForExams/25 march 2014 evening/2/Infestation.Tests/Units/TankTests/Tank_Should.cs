namespace Infestation.Tests.Units.TankTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Tank_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var tank = new Tank("Panzer");

            Assert.IsInstanceOf(typeof(Tank), tank);
        }

        [Test]
        public void ReturnCorrectPowerValue_WhenProperyPowerIsCalled()
        {
            var tank = new Tank("Panzer");

            Assert.AreEqual(25, tank.Power);
        }

        [Test]
        public void ReturnCorrectAggressionValue_WhenProperyAggressionIsCalled()
        {
            var tank = new Tank("Panzer");

            Assert.AreEqual(25, tank.Aggression);
        }

        [Test]
        public void ReturnCorrectHealthValue_WhenProperyHealthIsCalled()
        {
            var tank = new Tank("Panzer");

            Assert.AreEqual(20, tank.Health);
        }
    }
}

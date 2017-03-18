namespace Infestation.Tests.Units.MarineTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Marine_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var marine = new Marine("Pesho");

            Assert.IsInstanceOf(typeof(Marine), marine);
        }

        [Test]
        public void ReturnCorrectPowerValue_WhenProperyPowerIsCalled()
        {
            var marine = new Marine("Pesho");

            Assert.AreEqual(4, marine.Power);
        }

        [Test]
        public void ReturnCorrectAggressionValue_WhenProperyAggressionIsCalled()
        {
            var marine = new Marine("Pesho");

            Assert.AreEqual(1, marine.Aggression);
        }

        [Test]
        public void ReturnCorrectHealthValue_WhenProperyHealthIsCalled()
        {
            var marine = new Marine("Pesho");

            Assert.AreEqual(10, marine.Health);
        }
    }
}

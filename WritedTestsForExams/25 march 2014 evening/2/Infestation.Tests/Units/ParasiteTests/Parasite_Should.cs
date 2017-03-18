namespace Infestation.Tests.Units.ParasiteTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Parasite_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var parasite = new Parasite("Koko");

            Assert.IsInstanceOf(typeof(Parasite), parasite);
        }

        [Test]
        public void ReturnCorrectPowerValue_WhenProperyPowerIsCalled()
        {
            var parasite = new Parasite("Koko");

            Assert.AreEqual(1, parasite.Power);
        }

        [Test]
        public void ReturnCorrectAggressionValue_WhenProperyAggressionIsCalled()
        {
            var parasite = new Parasite("Koko");

            Assert.AreEqual(1, parasite.Aggression);
        }

        [Test]
        public void ReturnCorrectHealthValue_WhenProperyHealthIsCalled()
        {
            var parasite = new Parasite("Koko");

            Assert.AreEqual(1, parasite.Health);
        }
    }
}

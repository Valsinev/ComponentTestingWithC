using NUnit.Framework;
using System;

namespace Infestation.Tests.Supplements.InfestationSporesTests
{
    [TestFixture]
    public class InfestationSpores_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var spores = new InfestationSpores();

            Assert.IsInstanceOf(typeof(InfestationSpores), spores);
        }

        [Test]
        public void ReturnCorrectAggressionEffect()
        {
            var spores = new InfestationSpores();

            Assert.AreEqual(20, spores.AggressionEffect);
        }

        [Test]
        public void ReturnCorrectPowerEffect()
        {
            var spores = new InfestationSpores();

            Assert.AreEqual(-1, spores.PowerEffect);
        }

        [Test]
        public void RetudsarnCorrectHealthEffect()
        {
            var spores = new InfestationSpores();

            Assert.AreEqual(0, spores.HealthEffect);
        }

        [Test]
        public void RetudsarnCorrectAggressionEffect_WhenReactToOtherSupplement()
        {
            var spores = new InfestationSpores();

            var supplementToReact = new AggressionCatalyst();

            spores.ReactTo(supplementToReact);

            Assert.AreEqual(20, spores.AggressionEffect);
        }

        [Test]
        public void RetudsarnCorrectPowerEffect_WhenReactToOtherSupplement()
        {
            var spores = new InfestationSpores();

            var supplementToReact = new AggressionCatalyst();

            spores.ReactTo(supplementToReact);

            Assert.AreEqual(-1, spores.PowerEffect);
        }

        [Test]
        public void RetudsarnCorrectPowerEffect_WhenReactToSameSupplement()
        {
            var spores = new InfestationSpores();

            var anotherSpores = new InfestationSpores();

            spores.ReactTo(anotherSpores);

            Assert.AreEqual(0, spores.PowerEffect);
        }

        [Test]
        public void RetudsarnCorrectAggressionEffect_WhenReactToSameSupplement()
        {
            var spores = new InfestationSpores();

            var anotherSpores = new InfestationSpores();

            spores.ReactTo(anotherSpores);

            Assert.AreEqual(0, spores.AggressionEffect);
        }
    }
}

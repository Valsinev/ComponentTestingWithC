namespace Infestation.Tests.Supplements.HealthCatalystTests
{
    using NUnit.Framework;

    [TestFixture]
    public class HealthCatalyst_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var healthCatalystCatalust = new HealthCatalyst();

            Assert.IsInstanceOf(typeof(HealthCatalyst), healthCatalystCatalust);
        }
    }
}

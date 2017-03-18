namespace Infestation.Tests.Supplements.AggressionCatalystTests
{
    using NUnit.Framework;
    
    [TestFixture]
    public class AggressionCatalust_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var aggressionCatalust = new AggressionCatalyst();

            Assert.IsInstanceOf(typeof(AggressionCatalyst), aggressionCatalust);
        }
    }
}

using NUnit.Framework;
using System;

namespace Infestation.Tests.Supplements.AggressionCatalystTests
{
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

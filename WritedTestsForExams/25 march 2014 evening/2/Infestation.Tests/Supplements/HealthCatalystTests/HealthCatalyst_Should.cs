using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infestation.Tests.Supplements.HealthCatalystTests
{
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

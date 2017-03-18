namespace Cosmetics.Tests.Engine.CosmeticsEngineTests
{
    using System;

    using Cosmetics.Engine;
    using Moq;
    using NUnit.Framework;
    
    [TestFixture]
    public class CosmeticsEngine_Should
    {
        [Test]
        public void CreateInstanceOfCosmeticsEngine_WhenInstanceIsCalled()
        {
            var engine = CosmeticsEngine.Instance;

            Assert.IsInstanceOf(typeof(CosmeticsEngine), engine);
        }
    }
}

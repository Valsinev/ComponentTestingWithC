using NUnit.Framework;
using System;

namespace Infestation.Tests.Units.HumanTests
{
    [TestFixture]
    public class Human_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var dog = new Human("sharo");

            Assert.IsInstanceOf(typeof(Human), dog);
        }
    }
}

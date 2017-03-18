using NUnit.Framework;
using System;

namespace Infestation.Tests.Units.DogTests
{
    [TestFixture]
    public class Dog_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var dog = new Dog("sharo");

            Assert.IsInstanceOf(typeof(Dog), dog);
        }
    }
}

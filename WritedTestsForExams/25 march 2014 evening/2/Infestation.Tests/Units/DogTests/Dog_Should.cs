namespace Infestation.Tests.Units.DogTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Dog_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var dog = new Dog("sharo");

            Assert.IsInstanceOf(typeof(Dog), dog);
        }

        [Test]
        public void ReturnCorrectPowerValue_WhenProperyPowerIsCalled()
        {
            var dog = new Dog("sharo");

            Assert.AreEqual(5, dog.Power);
        }

        [Test]
        public void ReturnCorrectAggressionValue_WhenProperyAggressionIsCalled()
        {
            var dog = new Dog("sharo");

            Assert.AreEqual(2, dog.Aggression);
        }

        [Test]
        public void ReturnCorrectHealthValue_WhenProperyHealthIsCalled()
        {
            var dog = new Dog("sharo");

            Assert.AreEqual(4, dog.Health);
        }
    }
}

namespace FurnitureManufacturer.Tests.Models.FurnitureTests
{
    using System;

    using FurnitureManufacturer.Models;
    using NUnit.Framework;

    [TestFixture]
    public class Furniture_Should
    {
        [Test]
        public void ReturnCorrectNumberOfLegs_WhenNumberOfLegsIsCalled()
        {
            var chair = new Chair("Visage", "Wood", 65, 1.20m, 3);

            Assert.AreEqual(3, chair.NumberOfLegs);
        }

        [Test]
        public void ReturnCorrectModel_WhenModelIsCalled()
        {
            var chair = new Chair("Visage", "Wood", 65, 1.20m, 3);

            Assert.AreEqual("Visage", chair.Model);
        }

        [Test]
        public void ReturnCorrectMaterial_WhenMaterialIsCalled()
        {
            var chair = new Chair("Visage", "Wood", 65, 1.20m, 3);

            Assert.AreEqual("Wood", chair.Material);
        }

        [Test]
        public void ReturnCorrectPrice_WhenPriceIsCalled()
        {
            var chair = new Chair("Visage", "Wood", 65, 1.20m, 3);

            Assert.AreEqual(65, chair.Price);
        }

        [Test]
        public void ReturnCorrectHeight_WhenHeightIsCalled()
        {
            var chair = new Chair("Visage", "Wood", 65, 1.20m, 3);

            Assert.AreEqual(1.20, chair.Height);
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void ThrowArgumentException_WhenHeightIsNegativeOr0(int height)
        {
            Assert.Throws<ArgumentException>(() => new Chair("Visage", "Wood", 65, height, 3));
        }

        [Test]
        public void ThrowArgumentNullException_WhenMaterialEmptyString()
        {
            Assert.Throws<ArgumentNullException>(() => new Chair("Visage", string.Empty, 65, 1.20m, 3));
        }

        [Test]
        public void ThrowArgumentNullException_WhenMaterialIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Chair("Visage", null, 65, 1.20m, 3));
        }

        [Test]
        public void ThrowArgumentNullException_WhenModelIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Chair(null, "Wood", 65, 1.20m, 3));
        }

        [Test]
        public void ThrowArgumentNullException_WhenModelIsEmptyString()
        {
            Assert.Throws<ArgumentNullException>(() => new Chair(string.Empty, "Wood", 65, 1.20m, 3));
        }

        [TestCase(-1.2)]
        [TestCase(0)]
        public void ThrowArgumentException_WhenPriceIsNegativeOr0(decimal price)
        {
            Assert.Throws<ArgumentException>(() => new Chair("Visage", "Wood", price, 1.20m, 3));
        }
    }
}

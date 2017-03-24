namespace FurnitureManufacturer.Tests.Models.ChairTests
{
    using System;

    using FurnitureManufacturer.Models;
    using NUnit.Framework;

    [TestFixture]
    public class Chair_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var chair = new Chair("Visage", "Wood", 65, 1.20m, 4);

            Assert.IsInstanceOf(typeof(Chair), chair);
        }

        [Test]
        public void ThrowArgumentException_WhenConstructedChairWithNegativeLegs()
        {
            Assert.Throws<ArgumentException>(() => new Chair("Visage", "Wood", 65, 1.20m, -4));
        }

        [Test]
        public void ReturnCorrectNumberOfLegs_WhenNumberOfLegsIsCalled()
        {
            var chair = new Chair("Visage", "Wood", 65, 1.20m, 3);

            Assert.AreEqual(3, chair.NumberOfLegs);
        }

        [Test]
        public void ReturnCorrectToString_WhenToStringCalled()
        {
            var chair = new Chair("Visage", "Wood", 65, 1.20m, 3);

            string expected = "Type: Chair, Model: Visage, Material: Wood, Price: 65, Height: 1,20Legs: 3";

            Assert.AreEqual(expected, chair.ToString());
        }
    }
}

namespace FurnitureManufacturer.Tests.Models.ConvertibleChairTests
{
    using FurnitureManufacturer.Models;
    using NUnit.Framework;

    [TestFixture]
    public class ConvertibleChair_Should
    {
        [Test]
        public void NotBeConverted_WhenCreated()
        {
            var chair = new ConvertibleChair("Visage", "Wood", 65, 1.20m, 4);

            Assert.AreEqual(false, chair.IsConverted);
        }

        [Test]
        public void Convert_WhenConvertIsCalled()
        {
            var chair = new ConvertibleChair("Visage", "Wood", 65, 1.20m, 4);

            chair.Convert();

            Assert.AreEqual(true, chair.IsConverted);
        }

        [Test]
        public void ReturnCorrectHeight_WhenConvertIsCalled()
        {
            var chair = new ConvertibleChair("Visage", "Wood", 65, 1.20m, 4);

            chair.Convert();

            Assert.AreEqual(0.10, chair.Height);
        }

        [Test]
        public void ReturnCorrectHeight_ResetToInnitialHeight()
        {
            var chair = new ConvertibleChair("Visage", "Wood", 65, 1.20m, 4);

            chair.Convert();
            chair.Convert();

            Assert.AreEqual(1.20m, chair.Height);
        }

        [Test]
        public void ReturnCorrectString_WhenToStringIsCalled()
        {
            var chair = new ConvertibleChair("Visage", "Wood", 65, 1.20m, 4);

            string expected = "Type: ConvertibleChair, Model: Visage, Material: Wood, Price: 65, Height: 1,20Legs: 4State: Normal";

            Assert.AreEqual(expected, chair.ToString());
        }

        [Test]
        public void ReturnCorrectString_WhenToStringIsCalledWithConvertedState()
        {
            var chair = new ConvertibleChair("Visage", "Wood", 65, 1.20m, 4);

            chair.Convert();

            string expected = "Type: ConvertibleChair, Model: Visage, Material: Wood, Price: 65, Height: 0,10Legs: 4State: Converted";

            Assert.AreEqual(expected, chair.ToString());
        }
    }
}

namespace FurnitureManufacturer.Tests.Models.TableTests
{
    using FurnitureManufacturer.Models;
    using NUnit.Framework;

    [TestFixture]
    public class Table_Should
    {
        [Test]
        public void ReturnCorrectPrice_WhenPricePropertyIsCalled()
        {
            var table = new Table("Victoria", "Wood", 120, 100, 200, 200);

            Assert.AreEqual(120, table.Price);
        }

        [Test]
        public void ReturnCorrectHeight_WhenHeightPropertyIsCalled()
        {
            var table = new Table("Victoria", "Wood", 120, 100, 200, 200);

            Assert.AreEqual(100, table.Height);
        }

        [Test]
        public void ReturnCorrectLength_WhenLengthPropertyIsCalled()
        {
            var table = new Table("Victoria", "Wood", 120, 100, 220, 200);

            Assert.AreEqual(220, table.Length);
        }

        [Test]
        public void ReturnCorrectWidth_WhenWidthPropertyIsCalled()
        {
            var table = new Table("Victoria", "Wood", 120, 100, 220, 200);

            Assert.AreEqual(200, table.Width);
        }

        [Test]
        public void ReturnCorrectArea_WhenAreaPropertyIsCalled()
        {
            var table = new Table("Victoria", "Wood", 120, 100, 220, 200);

            Assert.AreEqual(44000, table.Area);
        }

        [Test]
        public void ReturnCorrectString_WhenToStringIsCalled()
        {
            var table = new Table("Victoria", "Wood", 120, 100, 220, 200);

            string expected = "Type: Table, Model: Victoria, Material: Wood, Price: 120, Height: 100Length: 220, Width: 200, Area: 44000";

            Assert.AreEqual(expected, table.ToString());
        }
    }
}

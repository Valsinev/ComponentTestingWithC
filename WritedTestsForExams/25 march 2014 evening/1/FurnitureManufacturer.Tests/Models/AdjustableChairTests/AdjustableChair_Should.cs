namespace FurnitureManufacturer.Tests.Models.AdjustableChairTests
{
    using FurnitureManufacturer.Models;
    using NUnit.Framework;

    [TestFixture]
    public class AdjustableChair_Should
    {
        [Test]
        public void SetHeight_WhenSetHeightWithValidDataIsPassed()
        {
            var adjustableChair = new AdjustableChair("Visage", "Wood", 65, 1.20m, 4);

            adjustableChair.SetHeight(0.10m);

            Assert.AreEqual(0.10, adjustableChair.Height);
        }

        [TestCase(0)]
        [TestCase(-1.2)]
        [TestCase(1.20)]
        public void NotSetHeight_WhenInvalidHeightIsPassed(decimal height)
        {
            var adjustableChair = new AdjustableChair("Visage", "Wood", 65, 1.20m, 4);

            adjustableChair.SetHeight(height);

            Assert.AreEqual(1.20, adjustableChair.Height);
        }
    }
}

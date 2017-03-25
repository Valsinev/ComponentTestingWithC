namespace FurnitureManufacturer.Tests.Engine.Factories.FurnitureFactoryTests
{
    using FurnitureManufacturer.Engine.Factories;
    using FurnitureManufacturer.Models;
    using NUnit.Framework;

    [TestFixture]
    public class FurnitureFactory_Should
    {
        [Test]
        public void CreateNewTable_WhenCreateTableWithValidDataIsPassed()
        {
            var factory = new FurnitureFactory();

            var newTable = factory.CreateTable("Victoria", "Wood", 120, 100, 200, 200);

            Assert.IsInstanceOf(typeof(Table), newTable);
        }

        [Test]
        public void CreateNewChair_WhenCreateChairWithValidDataIsPassed()
        {
            var factory = new FurnitureFactory();

            var newChair = factory.CreateChair("Visage", "Wood", 65, 1.20m, 4);

            Assert.IsInstanceOf(typeof(Chair), newChair);
        }

        [Test]
        public void CreateNewAdjustableChair_WhenCreateAdjustableChairWithValidDataIsPassed()
        {
            var factory = new FurnitureFactory();

            var newAdjustableChair = factory.CreateAdjustableChair("Visage", "Wood", 65, 1.20m, 4);

            Assert.IsInstanceOf(typeof(AdjustableChair), newAdjustableChair);
        }

        [Test]
        public void CreateNewConvertibleChair_WhenCreateConvertibleChairWithValidDataIsPassed()
        {
            var factory = new FurnitureFactory();

            var newConvertibleChair = factory.CreateConvertibleChair("Visage", "Wood", 65, 1.20m, 4);

            Assert.IsInstanceOf(typeof(ConvertibleChair), newConvertibleChair);
        }
    }
}

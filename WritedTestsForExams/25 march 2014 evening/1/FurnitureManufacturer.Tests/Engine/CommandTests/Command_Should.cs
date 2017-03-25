namespace FurnitureManufacturer.Tests.Engine.CommandTests
{
    using FurnitureManufacturer.Engine;
    using NUnit.Framework;

    [TestFixture]
    public class Command_Should
    {
        [Test]
        public void ReturnCorrectName_WhenCommandIsParsed()
        {
            var command = Command.Parse("CreateCompany Izgrev 0123456789");

            Assert.AreEqual("CreateCompany", command.Name);
        }

        [Test]
        public void ReturnFirstParameter_WhenCommandIsParsed()
        {
            var command = Command.Parse("CreateCompany Izgrev 0123456789");

            Assert.AreEqual("Izgrev", command.Parameters[0]);
        }

        [Test]
        public void ReturnSecondParameter_WhenCommandIsParsed()
        {
            var command = Command.Parse("CreateCompany Izgrev 0123456789");

            Assert.AreEqual("0123456789", command.Parameters[1]);
        }
    }
}

namespace Cosmetics.Tests.Engine.CommandTests
{
    using System;
    using System.Collections.Generic;

    using Cosmetics.Engine;
    using NUnit.Framework;

    [TestFixture]
    public class Command_Should
    {
        [Test]
        public void CreateInstanceOfCommand_WhenParseIsCalled()
        {
            var command = Command.Parse("AddToCategory");

            Assert.IsInstanceOf(typeof(Command), command);
        }

        [Test]
        public void ReturnCorrectName_WhenValidCommandNameIsPassed()
        {
            var command = Command.Parse("AddToCategory");

            Assert.AreEqual("AddToCategory", command.Name);
        }

        [Test]
        public void ReturnCorrParameters_WhenValidCommandDataIsPassed()
        {
            var command = Command.Parse("AddToCategory Pesho Nivea ");

            var expected = new List<string>() { "Pesho", "Nivea" };

            Assert.AreEqual(expected, command.Parameters);
        }
    }
}

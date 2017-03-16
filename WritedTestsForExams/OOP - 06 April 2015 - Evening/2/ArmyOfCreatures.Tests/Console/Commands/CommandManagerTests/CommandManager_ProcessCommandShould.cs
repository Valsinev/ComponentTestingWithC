using ArmyOfCreatures.Console.Commands;
using ArmyOfCreatures.Logic.Battles;
using Moq;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Commands.CommandManagerTests
{
    [TestFixture]
    public class CommandManager_ProcessCommandShould
    {
        [Test]
        public void ThrowArgumentNullException_WhenNullCommandLineIsPassed()
        {
            var cmanager = new CommandManager();

            var bmanager = new Mock<IBattleManager>();
            
            Assert.Throws<ArgumentNullException>(() => cmanager.ProcessCommand(null, bmanager.Object));
        }

        [Test]
        public void ThrowArgumentException_InvalidCommandLineIsPassed()
        {
            var cmanager = new CommandManager();

            var bmanager = new Mock<IBattleManager>();

            Assert.Throws<ArgumentException>(() => cmanager.ProcessCommand("add10Archangel(2)", bmanager.Object));
        }

        [Test]
        public void AddCreatures_IfValidValueIsPassed()
        {
            var cmanager = new CommandManager();

            var bmanager = new Mock<IBattleManager>();

            bmanager.Setup(x => x.AddCreatures(It.IsAny<CreatureIdentifier>(), It.IsAny<int>()));

            cmanager.ProcessCommand("add 10 Angel(2)", bmanager.Object);

            bmanager.Verify(x => x.AddCreatures(It.IsAny<CreatureIdentifier>(), It.IsAny<int>()));
        }
    }
}

using ArmyOfCreatures.Console.Commands;
using ArmyOfCreatures.Logic.Battles;
using Moq;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Commands.SkipCommandTests
{
    [TestFixture]
    public class SkipCommand_ProcessCommandShould
    {
        [Test]
        public void ThrowArgumentNullException_WhenNullBattleManagerIsPassed()
        {
            var skip = new SkipCommand();

            Assert.Throws<ArgumentNullException>(() => skip.ProcessCommand(null, new string[] { }));
        }

        [Test]
        public void ThrowArgumentNullException_WhenNullStringArgumentsPassed()
        {
            var skip = new SkipCommand();

            var bmanager = new Mock<IBattleManager>();

            Assert.Throws<ArgumentNullException>(() => skip.ProcessCommand(bmanager.Object, null));
        }

        [Test]
        public void ThrowArgumentException_WhenLessStringArgumentsArePassed()
        {
            var skip = new SkipCommand();

            var bmanager = new Mock<IBattleManager>();

            Assert.Throws<ArgumentException>(
                () => skip.ProcessCommand(bmanager.Object, new string[] { }));
        }

        [Test]
        public void CallSkipMethod_WhenValidDataIsPassed()
        {
            var skip = new SkipCommand();

            var bmanager = new Mock<IBattleManager>();

            bmanager.Setup(x => x.Skip(It.IsAny<CreatureIdentifier>()));

            skip.ProcessCommand(bmanager.Object, new string[] { "Archangel(2)" });

            bmanager.Verify(x => x.Skip(It.IsAny<CreatureIdentifier>()), Times.Once);
        }
    }
}

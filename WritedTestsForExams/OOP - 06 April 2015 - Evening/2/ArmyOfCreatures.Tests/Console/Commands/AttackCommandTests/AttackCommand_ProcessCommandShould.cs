using ArmyOfCreatures.Console.Commands;
using ArmyOfCreatures.Logic.Battles;
using Moq;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Commands.AttackCommandTests
{
    [TestFixture]
    public class AttackCommand_ProcessCommandShould
    {
        [Test]
        public void ThrowArgumentNullException_WhenNullBattleManagerIsPassed()
        {
            var attackCommand = new AttackCommand();

            Assert.Throws<ArgumentNullException>(() => attackCommand.ProcessCommand(null, new string[] { }));
        }

        [Test]
        public void ThrowArgumentNullException_WhenNullStringArgumentsPassed()
        {
            var attackCommand = new AttackCommand();

            var bmanager = new Mock<IBattleManager>();

            Assert.Throws<ArgumentNullException>(() => attackCommand.ProcessCommand(bmanager.Object, null));
        }

        [Test]
        public void ThrowArgumentException_WhenLessStringArgumentsArePassed()
        {
            var attackCommand = new AttackCommand();

            var bmanager = new Mock<IBattleManager>();
            
            Assert.Throws<ArgumentException>(() => attackCommand.ProcessCommand(bmanager.Object, new string[] { "Pesho" }));
        }

        [Test]
        public void CallAddCreaturesMethod_WhenValidDataIsPassed()
        {
            var attackCommand = new AttackCommand();

            var bmanager = new Mock<IBattleManager>();

            bmanager.Setup(x => x.Attack(It.IsAny<CreatureIdentifier>(), It.IsAny<CreatureIdentifier>()));

            attackCommand.ProcessCommand(bmanager.Object, new string[] { "Archangel(2)", "Angel(1)" });

            bmanager.Verify();
        }
    }
}

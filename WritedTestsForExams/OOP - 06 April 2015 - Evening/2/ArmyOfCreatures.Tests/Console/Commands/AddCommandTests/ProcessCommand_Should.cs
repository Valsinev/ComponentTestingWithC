namespace ArmyOfCreatures.Tests.Commands.AddCommandTests
{
    using System;
    using ArmyOfCreatures.Console.Commands;
    using ArmyOfCreatures.Logic.Battles;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class ProcessCommand_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenNullBattleManagerIsPassed()
        {
            var add = new AddCommand();

            Assert.Throws<ArgumentNullException>(() => add.ProcessCommand(null, new string[] { }));
        }

        [Test]
        public void ThrowArgumentNullException_WhenNullStringArgumentsPassed()
        {
            var add = new AddCommand();

            var bmanager = new Mock<IBattleManager>();

            Assert.Throws<ArgumentNullException>(() => add.ProcessCommand(bmanager.Object, null));
        }

        [Test]
        public void ThrowArgumentException_WhenLessStringArgumentsArePassed()
        {
            var add = new AddCommand();

            var bmanager = new Mock<IBattleManager>();

            Assert.Throws<ArgumentException>(
                () => add.ProcessCommand(bmanager.Object, new string[] { "Pesho" }));
        }

        [Test]
        public void CallAddCreaturesMethod_WhenValidDataIsPassed()
        {
            var add = new AddCommand();

            var bmanager = new Mock<IBattleManager>();

            bmanager.Setup(x => x.AddCreatures(It.IsAny<CreatureIdentifier>(), It.IsAny<int>()));
            
            add.ProcessCommand(bmanager.Object, new string[] { "10", "Archangel(2)" });

            bmanager.Verify(x => x.AddCreatures(It.IsAny<CreatureIdentifier>(), It.IsAny<int>()), Times.Once);
        }
    }
}

namespace ArmyOfCreatures.Tests.Battles.BattleManagerTests
{
    using System;

    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class AddCreatures_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenNullCreatureIdentifierIsPassed()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var bmanager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            Assert.Throws<ArgumentNullException>(() => bmanager.AddCreatures(null, 1));
        }

        [Test]
        public void CallCreateCreature_WhenValidIdentifierIsPassed()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var bmanager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            var creature = new Angel();

            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            bmanager.AddCreatures(identifier, 1);

            mockedFactory.Verify(x => x.CreateCreature(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void CallWriteLine_WhenValidIdentifierIsPassed()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var bmanager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            var creature = new Angel();

            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));

            bmanager.AddCreatures(identifier, 1);

            mockedLogger.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Once);
        }
    }
}

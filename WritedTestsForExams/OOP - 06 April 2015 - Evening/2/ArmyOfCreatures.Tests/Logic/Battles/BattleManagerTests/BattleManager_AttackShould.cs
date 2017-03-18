namespace ArmyOfCreatures.Tests.Logic.Battles.BattleManagerTests
{
    using System;

    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Tests.MockedClasses;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class BattleManager_AttackShould
    {
        [Test]
        public void ThrowArgumentException_WhenNullAttackerCreatureIsPassed()
        {
            var creatureFactoryMock = new Mock<ICreaturesFactory>();
            var loggerMock = new Mock<ILogger>();

            var battleManager = new BattleManager(creatureFactoryMock.Object, loggerMock.Object);

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Pesho(1)");

            Assert.Throws<ArgumentException>(() => battleManager.Attack(identifier, identifier));
        }

        [Test]
        public void CallWriteLine4Times_WhenAttackIsSucessful()
        {
            var creatureFactoryMock = new Mock<ICreaturesFactory>();
            var loggerMock = new Mock<ILogger>();
        
            var battleManager = new MockedBattleManager(creatureFactoryMock.Object, loggerMock.Object);
        
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            creatureFactoryMock.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(new Angel());

            battleManager.AddCreatures(identifier, 1);
            
            loggerMock.Setup(x => x.WriteLine(It.IsAny<string>()));
        
            battleManager.Attack(identifier, identifier);
        
            loggerMock.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(4));
        }
    }
}

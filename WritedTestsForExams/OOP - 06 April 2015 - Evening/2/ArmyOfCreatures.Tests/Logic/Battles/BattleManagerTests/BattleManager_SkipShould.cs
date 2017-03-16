using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Tests.MockedClasses;
using Moq;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Logic.Battles.BattleManagerTests
{
    [TestFixture]
    public class BattleManager_SkipShould
    {
        [Test]
        public void ThrowArgumentException_WhenNullCreatureIsPassed()
        {
            var loggerMock = new Mock<ILogger>();
            var factoryMock = new Mock<ICreaturesFactory>();

            var battleManager = new BattleManager(factoryMock.Object, loggerMock.Object);

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Pesho(1)");

            Assert.Throws<ArgumentException>(() => battleManager.Skip(identifier));
        }

        [Test]
        public void CallWriteLineExactly2Times_WhenValidValueIsPassed()
        {
            var loggerMock = new Mock<ILogger>();
            var factoryMock = new Mock<ICreaturesFactory>();

            loggerMock.Setup(x => x.WriteLine(It.IsAny<string>()));

            var battleManager = new MockedBattleManager(factoryMock.Object, loggerMock.Object);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            battleManager.FirstArmyCreatures.Add(creaturesInBattle);
            
            battleManager.Skip(identifier);
            
            loggerMock.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(2));
        }
    }
}

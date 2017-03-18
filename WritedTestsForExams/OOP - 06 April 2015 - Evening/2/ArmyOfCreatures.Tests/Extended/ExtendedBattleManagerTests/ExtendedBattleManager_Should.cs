namespace ArmyOfCreatures.Tests.Extended.ExtendedBattleManagerTests
{
    using System.Linq;

    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Tests.MockedClasses;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class ExtendedBattleManager_Should
    {
        [Test]
        public void AddCreaturesInThirdArmy_WhenCorrectDataIsPassed()
        {
            var logger = new Mock<ILogger>();
            var factory = new Mock<ICreaturesFactory>();

            var creature = new Angel();

            factory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            var battleManager = new MockedBattleManager(factory.Object, logger.Object);

            var creatureIdentifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(3)");

            battleManager.AddCreatures(creatureIdentifier, 1);

            var result = battleManager.ThirdArmyCreatures.FirstOrDefault();

            Assert.IsInstanceOf(typeof(CreaturesInBattle), result);
        }
    }
}

using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using NUnit.Framework;

namespace ArmyOfCreatures.Tests.Logic.Battles.CreaturesInBattleTests.Skip
{
    [TestFixture]
    public class CreaturesInBattle_SkipShould
    {
        [Test]
        public void AddCorrectPermanentDeffenseBonus_WhenSkipCommandIsCalled()
        {
            var ang = new Angel();

            var creatureInBattle = new CreaturesInBattle(ang, 1);

            creatureInBattle.Skip();

            Assert.AreEqual(23, creatureInBattle.PermanentDefense);
        }
    }
}

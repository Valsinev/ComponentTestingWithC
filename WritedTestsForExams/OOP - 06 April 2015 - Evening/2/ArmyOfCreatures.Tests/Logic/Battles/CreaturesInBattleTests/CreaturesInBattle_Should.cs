namespace ArmyOfCreatures.Tests.Logic.Battles.CreaturesInBattleTests
{
    using System;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Tests.MockedClasses;
    using NUnit.Framework;

    [TestFixture]
    public class CreaturesInBattle_Should
    {
        [Test]
        public void ReturnCorrectCreature_WhenConstructed()
        {
            var ang = new Angel();

            var creatureInBattle = new CreaturesInBattle(ang, 2);

            Assert.AreEqual(ang, creatureInBattle.Creature);
        }

        [Test]
        public void CreaturePermanentAttack_WhenConstructed()
        {
            var ang = new Angel();

            var creatureInBattle = new CreaturesInBattle(ang, 2);

            Assert.AreEqual(20, creatureInBattle.PermanentAttack);
        }

        [Test]
        public void CreaturePermanentDefense_WhenConstructed()
        {
            var ang = new Angel();

            var creatureInBattle = new CreaturesInBattle(ang, 2);

            Assert.AreEqual(20, creatureInBattle.PermanentDefense);
        }

        [Test]
        public void CreaturesTotalHitPoints_WhenConstructed()
        {
            var ang = new Angel();

            var creatureInBattle = new CreaturesInBattle(ang, 2);

            Assert.AreEqual(400, creatureInBattle.TotalHitPoints);
        }

        [Test]
        public void Return0HitPoints_WhenTotalHitPointsIsBellow0()
        {
            var ang = new AngelMock();

            var creatureInBattle = new CreaturesInBattle(ang, 2);

            Assert.AreEqual(0, creatureInBattle.TotalHitPoints);
        }

        [Test]
        public void ReturnCorrectStringFormat_WhenValidCreatureIsPassed()
        {
            var creaturesInBattle = new CreaturesInBattle(new Angel(), 2);

            var expectedStringFormat = "2 Angel (ATT:20; DEF:20; THP:400; LDMG:0)";

            Assert.AreEqual(expectedStringFormat, creaturesInBattle.ToString());
        }
    }
}

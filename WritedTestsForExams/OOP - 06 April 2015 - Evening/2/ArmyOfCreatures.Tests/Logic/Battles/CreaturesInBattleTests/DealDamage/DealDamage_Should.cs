namespace ArmyOfCreatures.Tests.Logic.Battles.CreaturesInBattleTests.DealDamage
{
    using System;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;
    using NUnit.Framework;

    [TestFixture]
    public class DealDamage_Should
    {
        [Test]
        public void ReturnCorrectDefenderHitPoints_WhenDefenceIsNotHighterThanDamage()
        {
            var attackerInBattle = new CreaturesInBattle(new Angel(), 1);
            var defenderInBattle = new CreaturesInBattle(new Angel(), 1);
            
            var angelHitPointsAfterAngelAttack = 200 - 50;

            attackerInBattle.DealDamage(defenderInBattle);

            Assert.AreEqual(angelHitPointsAfterAngelAttack, defenderInBattle.TotalHitPoints);
        }

        [Test]
        public void ThrowsArgumentNullException_WhenDefenderInBattleIsNull()
        {
            var attackerInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() => attackerInBattle.DealDamage(null));
        }
    }
}

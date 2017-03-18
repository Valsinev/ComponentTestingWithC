namespace ArmyOfCreatures.Tests.Logic.Specialities.ReduceEnemyDefenseByPercentageTests
{
    using System;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;
    using NUnit.Framework;

    [TestFixture]
    public class ReduceEnemyDefenseByPercentage_Should
    {
        [TestCase(-0.5)]
        [TestCase(100.2)]
        public void ThrowArgumentOutOfRangeException_WhenPercentagesAreOutOfRange(decimal percentage)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new ReduceEnemyDefenseByPercentage(percentage));
        }

        [Test]
        public void ThrowArgumentNullException_WhenApplyWhenAttackingIsCalledWithNullAttacker()
        {
            var reduceEnemyDefenseByPercentage = new ReduceEnemyDefenseByPercentage(2.5m);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() => reduceEnemyDefenseByPercentage.ApplyWhenAttacking(null, creaturesInBattle));
        }

        [Test]
        public void ThrowArgumentNullException_WhenApplyWhenAttackingIsCalledWithNullDefender()
        {
            var reduceEnemyDefenseByPercentage = new ReduceEnemyDefenseByPercentage(2.5m);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() => reduceEnemyDefenseByPercentage.ApplyWhenAttacking(creaturesInBattle, null));
        }

        [Test]
        public void ReturnCorrectDefenseChanges_WhenApplyWhenAttackingIsCalled()
        {
            var reduceEnemyDefenseByPercentage = new ReduceEnemyDefenseByPercentage(10m);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            reduceEnemyDefenseByPercentage.ApplyWhenAttacking(creaturesInBattle, creaturesInBattle);

            Assert.AreEqual(18, creaturesInBattle.CurrentDefense);
        }

        [Test]
        public void ReturnCorrectStringFormat_WhenToStringIsCalled()
        {
            var reduceEnemyDefenseByPercentage = new ReduceEnemyDefenseByPercentage(2.5m);

            Assert.AreEqual("ReduceEnemyDefenseByPercentage(2.5)", reduceEnemyDefenseByPercentage.ToString());
        }
    }
}

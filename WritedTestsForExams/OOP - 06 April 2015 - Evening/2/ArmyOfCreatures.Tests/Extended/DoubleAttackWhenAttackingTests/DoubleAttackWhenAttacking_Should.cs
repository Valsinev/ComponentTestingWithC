namespace ArmyOfCreatures.Tests.Extended.DoubleAttackWhenAttackingTests
{
    using System;

    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;
    using NUnit.Framework;

    [TestFixture]
    public class DoubleAttackWhenAttacking_Should
    {
        [Test]
        public void ThrowArgumentOutOfRangeException_WhenInvalidRoundCountIsPassed()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new DoubleAttackWhenAttacking(0));
        }

        [Test]
        public void ThrowArgumentNullException_WhenNullAttackerWithSpecialtyIsPassed()
        {
            var doubleAttackWhenAttacking = new DoubleAttackWhenAttacking(5);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() =>
                doubleAttackWhenAttacking.ApplyWhenAttacking(null, creaturesInBattle));
        }

        [Test]
        public void ThrowArgumentNullException_WhenNullDefenderWithSpecialtyIsPassed()
        {
            var doubleAttackWhenAttacking = new DoubleAttackWhenAttacking(5);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            Assert.Throws<ArgumentNullException>(() => 
                doubleAttackWhenAttacking.ApplyWhenAttacking(creaturesInBattle, null));
        }

        [Test]
        public void ReturnCorrectStringFormat_WhenToStringMethodIsCalled()
        {
            var doubleAttackWhenAttacking = new DoubleAttackWhenAttacking(5);

            Assert.AreEqual("DoubleAttackWhenAttacking(5)", doubleAttackWhenAttacking.ToString());
        }

        [Test]
        public void AddCorrectCurrentAttackBonus_WhenRoundsAreAbove0()
        {
            var doubleAttackWhenAttacking = new DoubleAttackWhenAttacking(5);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            doubleAttackWhenAttacking.ApplyWhenAttacking(creaturesInBattle, creaturesInBattle);

            Assert.AreEqual(40, creaturesInBattle.CurrentAttack);
        }

        [Test]
        public void ResetToPermanentAttack_WhenRoundsGoBellow1()
        {
            var doubleAttackWhenAttacking = new DoubleAttackWhenAttacking(1);

            var creaturesInBattle = new CreaturesInBattle(new Angel(), 1);

            doubleAttackWhenAttacking.ApplyWhenAttacking(creaturesInBattle, creaturesInBattle);
            doubleAttackWhenAttacking.ApplyWhenAttacking(creaturesInBattle, creaturesInBattle);

            Assert.AreEqual(40, creaturesInBattle.CurrentAttack);
        }
    }
}

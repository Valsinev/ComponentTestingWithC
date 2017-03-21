namespace Infestation.Tests.Units.UnitTests
{
    using System;
    using System.Collections.Generic;

    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Unit_Should
    {
        [Test]
        public void ReturnCorrechHealthValue_WhenDecreaseBaseHealthIsCalled()
        {
            var unit = new Tank("Panzer");

            unit.DecreaseBaseHealth(5);

            Assert.AreEqual(15, unit.Health);
        }

        [Test]
        public void ReturnCorrectPowerValue_WhenPowerChangingSupplementIsAdded()
        {
            var unit = new Tank("Panzer");

            var powerCatalyst = new PowerCatalyst();

            unit.AddSupplement(powerCatalyst);

            Assert.AreEqual(28, unit.Power);
        }

        [Test]
        public void ReturnCorrectHealthValue_WhenHealthChangingSupplementIsAdded()
        {
            var unit = new Tank("Panzer");

            var healthCatalyst = new HealthCatalyst();

            unit.AddSupplement(healthCatalyst);

            Assert.AreEqual(23, unit.Health);
        }

        [Test]
        public void ReturnCorrecAggressionValue_WhenAggressionChangingSupplementIsAdded()
        {
            var unit = new Tank("Panzer");

            var aggressionCatalyst = new AggressionCatalyst();

            unit.AddSupplement(aggressionCatalyst);

            Assert.AreEqual(28, unit.Aggression);
        }

        [Test]
        public void ReturnCorrectAggressionValue_WeaponSupplementReactToWeaponarySkillSupplement()
        {
            var unit = new Tank("Panzer");

            var weaponrySkill = new WeaponrySkill();
            var weaponMock = new Mock<Weapon>();

            weaponMock.Setup(x => x.ReactTo(It.IsAny<ISupplement>()));

            unit.AddSupplement(weaponrySkill);
            unit.AddSupplement(weaponMock.Object);

            weaponMock.Verify(x => x.ReactTo(It.IsAny<ISupplement>()), Times.Once);
        }

        [TestCase(20)]
        [TestCase(100)]
        public void BeDestroyed_WhenHealthIs0OrBellow(int damage)
        {
            var unit = new Tank("Panzer");

            unit.DecreaseBaseHealth(damage);

            Assert.AreEqual(true, unit.IsDestroyed);
        }

        [Test]
        public void NotBeDestroyed_WhenHealthIsAbove0()
        {
            var unit = new Tank("Panzer");

            unit.DecreaseBaseHealth(5);

            Assert.AreEqual(false, unit.IsDestroyed);
        }

        [Test]
        public void ReturnUnitInfo_WhenInfoIsCalled()
        {
            var unit = new Tank("Panzer");

            var tankInfo = new UnitInfo(unit);

            Assert.AreEqual(tankInfo, unit.Info);
        }

        [Test]
        public void ReturnCorrectToString_WhenToStringIsCalled()
        {
            var dog = new Dog("Sharo");

            dog.AddSupplement(new AggressionCatalyst());
            dog.AddSupplement(new PowerCatalyst());

            string expected = 
                "Dog Sharo (Biological) [Health: 4, Power: 8, Aggression: 5, Supplements: [AggressionCatalyst, PowerCatalyst]]";

            Assert.AreEqual(expected, dog.ToString());
        }

        [Test]
        public void ReturnCorrectToStringWithNoSupplements_WhenToStringIsCalled()
        {
            var dog = new Dog("Sharo");

            string expected = 
                "Dog Sharo (Biological) [Health: 4, Power: 5, Aggression: 2, Supplements: []]";

            Assert.AreEqual(expected, dog.ToString());
        }

        [Test]
        public void ReturnCorrectBonusAggression_WhenWeaponSupplementReactToWeaponarySkillSupplement()
        {
            var unit = new Tank("Panzer");

            unit.AddSupplement(new WeaponrySkill());
            unit.AddSupplement(new Weapon());
            
            Assert.AreEqual(28, unit.Aggression);
        }

        [Test]
        public void ReturnCorrectBonusPower_WhenWeaponSupplementReactToWeaponarySkillSupplement()
        {
            var unit = new Tank("Panzer");

            unit.AddSupplement(new WeaponrySkill());
            unit.AddSupplement(new Weapon());

            Assert.AreEqual(35, unit.Power);
        }

        [Test]
        public void Attack_WhenCorrectConditionsArePassed()
        {
            var unit = new Tank("Panzer");

            List<UnitInfo> units = new List<UnitInfo>();

            var dog = new UnitInfo(new Dog("Tereza"));

            units.Add(dog);

            var result = unit.DecideInteraction(units);
            
            Assert.AreEqual(InteractionType.Attack, result.InteractionType);
        }

        [Test]
        public void ReturnNullInteraction_WhenUnitTryToAttackItself()
        {
            var unit = new Tank("Panzer");

            List<UnitInfo> units = new List<UnitInfo>();

            var tank = new UnitInfo(unit);

            units.Add(tank);

            var result = unit.DecideInteraction(units);

            Assert.AreEqual(null, result);
        }
    }
}

namespace Infestation.Tests.Supplements.WeaponTests
{
    using NUnit.Framework;
    
    [TestFixture]
    public class Weapon_Should
    {
        [Test]
        public void HaveNoAggressionEffect_WhenInitialyCreated()
        {
            var weapon = new Weapon();

            Assert.AreEqual(0, weapon.AggressionEffect);
        }

        [Test]
        public void HaveNoHealthEffect_WhenInitialyCreated()
        {
            var weapon = new Weapon();

            Assert.AreEqual(0, weapon.HealthEffect);
        }

        [Test]
        public void HaveNoPowerEffect_WhenInitialyCreated()
        {
            var weapon = new Weapon();

            Assert.AreEqual(0, weapon.PowerEffect);
        }

        [Test]
        public void Have_WhenInitialyCreated()
        {
            var weapon = new Weapon();

            weapon.ReactTo(new WeaponrySkill());

            Assert.AreEqual(3, weapon.AggressionEffect);
        }
    }
}

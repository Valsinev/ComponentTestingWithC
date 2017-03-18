namespace Infestation.Tests.Supplements.WeaponarySkillTests
{
    using System;

    using Infestation;
    using NUnit.Framework;

    [TestFixture]
    public class WeaponarySkill_Should
    {
        [Test]
        public void ThrowNotImplementedException_WhenReactToIsCalled()
        {
            var weaponarySkill = new WeaponrySkill();

            Assert.Throws<NotImplementedException>(() => weaponarySkill.ReactTo(new Weapon()));
        }
    }
}

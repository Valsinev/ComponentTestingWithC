namespace Infestation.Tests.Units.MarineTests
{
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class Marine_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var marine = new Marine("Pesho");

            Assert.IsInstanceOf(typeof(Marine), marine);
        }

        [Test]
        public void ReturnCorrectPowerValue_WhenProperyPowerIsCalled()
        {
            var marine = new Marine("Pesho");

            Assert.AreEqual(4, marine.Power);
        }

        [Test]
        public void ReturnCorrectAggressionValue_WhenProperyAggressionIsCalled()
        {
            var marine = new Marine("Pesho");

            Assert.AreEqual(1, marine.Aggression);
        }

        [Test]
        public void ReturnCorrectHealthValue_WhenProperyHealthIsCalled()
        {
            var marine = new Marine("Pesho");

            Assert.AreEqual(10, marine.Health);
        }

        [Test]
        public void ReturnAttackInteractionType_WhenInteractWithAttackableUnit()
        {
            var marine = new Marine("Pesho");

            var parasite = new Parasite("Boris");
            var queen = new Queen("Tereza");

            var parasiteInfo = new UnitInfo(parasite);
            var queenInfo = new UnitInfo(queen);
            var marineInfo = new UnitInfo(marine);

            List<UnitInfo> units = new List<UnitInfo>();

            units.Add(parasiteInfo);
            units.Add(queenInfo);

            var result = marine.DecideInteraction(units);
            var expected = new Interaction(marineInfo, queenInfo, InteractionType.Attack);

            Assert.AreEqual(expected.InteractionType, result.InteractionType);
        }

        [Test]
        public void TargetUnithWithMaxHealth_WhenThereAreMoreThanOneUnit()
        {
            var marine = new Marine("Pesho");

            var parasite = new Parasite("Boris");
            var queen = new Queen("Tereza");

            var parasiteInfo = new UnitInfo(parasite);
            var queenInfo = new UnitInfo(queen);
            var marineInfo = new UnitInfo(marine);

            List<UnitInfo> units = new List<UnitInfo>();

            units.Add(parasiteInfo);
            units.Add(queenInfo);

            var result = marine.DecideInteraction(units);
            var expected = new Interaction(marineInfo, queenInfo, InteractionType.Attack);

            Assert.AreEqual(expected.TargetUnit, result.TargetUnit);
        }
    }
}

namespace Infestation.Tests.Units.QueenTests
{
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class Queen_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var queen = new Queen("Tereza");

            Assert.IsInstanceOf(typeof(Queen), queen);
        }

        [Test]
        public void ReturnCorrectPowerValue_WhenProperyPowerIsCalled()
        {
            var queen = new Queen("Tereza");

            Assert.AreEqual(1, queen.Power);
        }

        [Test]
        public void ReturnCorrectAggressionValue_WhenProperyAggressionIsCalled()
        {
            var queen = new Queen("Tereza");

            Assert.AreEqual(1, queen.Aggression);
        }

        [Test]
        public void ReturnCorrectHealthValue_WhenProperyHealthIsCalled()
        {
            var queen = new Queen("Tereza");

            Assert.AreEqual(30, queen.Health);
        }

        [Test]
        public void Infest_WhenDecideInteractionWithValidDataIsPassed()
        {
            var queen = new Queen("Tereza");
            var target = new Queen("Lea");

            var targetInfo = new UnitInfo(target);
            var queenInfo = new UnitInfo(queen);

            List<UnitInfo> units = new List<UnitInfo>();

            units.Add(targetInfo);

            var result = queen.DecideInteraction(units);

            var expected = new Interaction(queenInfo, targetInfo, InteractionType.Infest);

            Assert.AreEqual(expected.InteractionType, result.InteractionType);
        }

        [Test]
        public void ReturnPassiveInteraction_WhenUnitInfoWithNullIdIsPassed()
        {
            var queen = new Queen("Tereza");
            var marine = new Marine(null);

            var marineInfo = new UnitInfo(marine);
            var queenInfo = new UnitInfo(queen);

            List<UnitInfo> units = new List<UnitInfo>();

            units.Add(marineInfo);

            var result = queen.DecideInteraction(units);

            var expected = Interaction.PassiveInteraction;

            Assert.AreEqual(expected, result);
        }
    }
}

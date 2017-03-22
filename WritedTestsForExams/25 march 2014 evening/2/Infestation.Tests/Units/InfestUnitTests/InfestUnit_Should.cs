namespace Infestation.Tests.Units.InfestUnitTests
{
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class InfestUnit_Should
    {
        [Test]
        public void ReturnInfestInteraction_WhenDecideInteractionWithValidUnitIsCalled()
        {
            var infestUnit = new Parasite("Boris");

            List<UnitInfo> units = new List<UnitInfo>();

            var dog = new UnitInfo(new Dog("Sharo"));

            units.Add(dog);

            var result = infestUnit.DecideInteraction(units);

            Assert.AreEqual(InteractionType.Infest, result.InteractionType);
        }

        [Test]
        public void ReturnPassiveInteraction_WhenDecideInteractionIsCalledWithNullUnitId()
        {
            var infestUnit = new Parasite("Boris");

            List<UnitInfo> units = new List<UnitInfo>();

            var parasite = new Parasite(null);

            var unitInfo = new UnitInfo(parasite);

            units.Add(unitInfo);

            var result = infestUnit.DecideInteraction(units);

            Assert.AreEqual(Interaction.PassiveInteraction, result);
        }
    }
}

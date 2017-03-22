namespace Infestation.Tests.Engine.InfestationRequirementsTests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class InfestationRequirements_Should
    {
        [Test]
        public void ReturnPrionicUnitClassification_WhenRequiredClassificationToInfestIsCalledWithMechanicalUnit()
        {
            var tank = new Tank("Panzer");

            var classificationResult = InfestationRequirements.RequiredClassificationToInfest(tank.UnitClassification);

            Assert.AreEqual(UnitClassification.Psionic, classificationResult);
        }

        [Test]
        public void ReturnBiologicalUnitClassification_WhenRequiredClassificationToInfestIsCalledWithBiologicalUnit()
        {
            var human = new Human("Pesho");

            var classificationResult = InfestationRequirements.RequiredClassificationToInfest(human.UnitClassification);

            Assert.AreEqual(UnitClassification.Biological, classificationResult);
        }

        [Test]
        public void ReturnPsionicUnitClassification_WhenRequiredClassificationToInfestIsCalledWithPsionicUnit()
        {
            var queen = new Queen("Tereza");

            var classificationResult = InfestationRequirements.RequiredClassificationToInfest(queen.UnitClassification);

            Assert.AreEqual(UnitClassification.Psionic, classificationResult);
        }

        [Test]
        public void ThrowInvalidOperationException_WhenRequiredClassificationToInfestIsCalledWithUnknownClassification()
        {
            Assert.Throws<InvalidOperationException>(() => InfestationRequirements.RequiredClassificationToInfest(UnitClassification.Unknown));
        }
    }
}

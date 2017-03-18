namespace Infestation.Tests.Units.QueenTests
{
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
    }
}

using ArmyOfCreatures.Logic.Battles;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Logic.Battles.CreatureIdentifierTests
{
    [TestFixture]
    public class CreatureIdentifier_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenNullStringIsPassed()
        {
            Assert.Throws<ArgumentNullException>(
                () => CreatureIdentifier.CreatureIdentifierFromString(null));
        }

        [Test]
        public void ReturnCorrectCreatureType_WhenExpectedStringIsPassed()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual("Angel", identifier.CreatureType);
        }

        [Test]
        public void ReturnCorrectCreatureArmy_WhenExpectedStringIsPassed()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual(1, identifier.ArmyNumber);
        }

        [Test]
        public void ThrowIndexOutOfRangeException_WhenInvalidStringIsPassed()
        {
            Assert.Throws<IndexOutOfRangeException>(
                () => CreatureIdentifier.CreatureIdentifierFromString("Angel"));
        }

        [Test]
        public void ReturnCorrectStringFormat_WhenValidStringIsPassed()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual("Angel(1)", identifier.ToString());
        }
    }
}

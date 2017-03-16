using ArmyOfCreatures.Extended;
using ArmyOfCreatures.Extended.Creatures;
using ArmyOfCreatures.Logic.Creatures;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests.Logic.CreaturesFactoryTests
{
    [TestFixture]
    public class ExtendedCreaturesFactory_Should
    {
        [TestCase("Angel", typeof(Angel))]
        [TestCase("Archangel", typeof(Archangel))]
        [TestCase("ArchDevil", typeof(ArchDevil))]
        [TestCase("Behemoth", typeof(Behemoth))]
        [TestCase("Devil", typeof(Devil))]
        [TestCase("AncientBehemoth", typeof(AncientBehemoth))]
        [TestCase("CyclopsKing", typeof(CyclopsKing))]
        [TestCase("Goblin", typeof(Goblin))]
        [TestCase("Griffin", typeof(Griffin))]
        [TestCase("WolfRaider", typeof(WolfRaider))]
        public void ReturnTheCorrectCreatureType_WhenValidCreatureIsPassed(string creature, Type type)
        {
            var factory = new ExtendedCreaturesFactory();

            var cr = factory.CreateCreature(creature);

            Assert.AreEqual(type, cr.GetType());
        }

        [Test]
        public void ThrowArgumentException_InvalidValueIsPassed()
        {
            var factory = new ExtendedCreaturesFactory();

            Assert.Throws<ArgumentException>(() => factory.CreateCreature("Pesho"));
        }
    }
}

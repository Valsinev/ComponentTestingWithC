namespace ArmyOfCreatures.Tests.MockedClasses
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using ArmyOfCreatures.Extended;
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;
    
    public class MockedBattleManager : ExtendedBattleManager
    {
        public MockedBattleManager(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.FirstArmyCreatures = new List<ICreaturesInBattle>();
            this.SecondArmyCreatures = new List<ICreaturesInBattle>();
            this.ThirdArmyCreatures = new List<ICreaturesInBattle>();
        }

        public ICollection<ICreaturesInBattle> FirstArmyCreatures { get; set; }

        public ICollection<ICreaturesInBattle> SecondArmyCreatures { get; set; }

        public ICollection<ICreaturesInBattle> ThirdArmyCreatures { get; set; }
        
        public override void AddCreatures(CreatureIdentifier creatureIdentifier, int count)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            var creature = this.CreaturesFactory.CreateCreature(creatureIdentifier.CreatureType);
            var creaturesInBattle = new CreaturesInBattle(creature, count);
            this.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            if (identifier.ArmyNumber == 1)
            {
                return this.FirstArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }

            if (identifier.ArmyNumber == 2)
            {
                return this.SecondArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }

            if (identifier.ArmyNumber == 3)
            {
                return this.ThirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }

            throw new ArgumentException(
                string.Format(CultureInfo.InvariantCulture, "Invalid ArmyNumber: {0}", identifier.ArmyNumber));
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == 1)
            {
                this.FirstArmyCreatures.Add(creaturesInBattle);
            }
            else if (creatureIdentifier.ArmyNumber == 2)
            {
                this.SecondArmyCreatures.Add(creaturesInBattle);
            }
            else if (creatureIdentifier.ArmyNumber == 3)
            {
                this.ThirdArmyCreatures.Add(creaturesInBattle);
            }
            else
            {
                throw new ArgumentException(
                    string.Format(CultureInfo.InvariantCulture, "Invalid ArmyNumber: {0}", creatureIdentifier.ArmyNumber));
            }
        }
    }
}

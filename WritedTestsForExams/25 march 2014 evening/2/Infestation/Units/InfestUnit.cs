using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class InfestUnit : Unit
    {
        public InfestUnit(string id, UnitClassification unitType, int health, int power, int aggression)
            : base(id, unitType, health, power, aggression)
        {
        }
        protected override bool CanAttackUnit(UnitInfo unit)
        {
            bool attackUnit = false;
            if (this.Id != unit.Id && 
                InfestationRequirements.RequiredClassificationToInfest(unit.UnitClassification) == this.UnitClassification)
            {
                attackUnit = true;
            }
            return attackUnit;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);

            var targetsDifferentThanItself = attackableUnits.Where(u => u.GetType().Name != this.GetType().Name);
            foreach (var target in targetsDifferentThanItself)
            {
                optimalAttackableUnit = targetsDifferentThanItself.OrderBy(u => u.Health).FirstOrDefault();
            }
            return optimalAttackableUnit;
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }

    }
    
}

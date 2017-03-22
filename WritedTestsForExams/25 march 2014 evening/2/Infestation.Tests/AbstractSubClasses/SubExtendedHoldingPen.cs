namespace Infestation.Tests.AbstractSubClasses
{
    using System.Collections.Generic;
    using System.Linq;
    
    public class SubExtendedHoldingPen : ExtendedHoldingPen
    {
        private List<Unit> containedUnits = new List<Unit>();

        public List<Unit> ContainedUnits
        {
            get
            {
                return this.containedUnits;
            }

            set
            {
                this.containedUnits = value;
            }
        }

        protected override void ExecuteProceedSingleIterationCommand()
        {
            var containedUnitsInfo = this.containedUnits.Select((unit) => unit.Info);

            IEnumerable<Interaction> requestedInteractions =
                from unit in this.containedUnits
                select unit.DecideInteraction(containedUnitsInfo);

            requestedInteractions = requestedInteractions.Where((interaction) => interaction != Interaction.PassiveInteraction);

            foreach (var interaction in requestedInteractions)
            {
                this.ProcessSingleInteraction(interaction);
            }

            this.containedUnits.RemoveAll((unit) => unit.IsDestroyed);
        }

        protected override void InsertUnit(Unit unit)
        {
            this.containedUnits.Add(unit);
        }

        protected override Unit GetUnit(string unitId)
        {
            return this.containedUnits.FirstOrDefault((unit) => unit.Id == unitId);
        }

        protected override Unit GetUnit(UnitInfo unitInfo)
        {
            return this.GetUnit(unitInfo.Id);
        }
    }
}

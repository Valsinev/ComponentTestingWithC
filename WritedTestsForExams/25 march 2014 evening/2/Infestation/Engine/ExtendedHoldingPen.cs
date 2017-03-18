using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class ExtendedHoldingPen : HoldingPen
    {
        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    Unit targetUnit = this.GetUnit(interaction.TargetUnit);

                    targetUnit.AddSupplement(new InfestationSpores());
                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
        }
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
        }
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            ISupplement suplement = null;
            switch (commandWords[1])
            {
                case "Weapon":
                    suplement = new Weapon();
                    break;
                case "AggressionCatalyst":
                    suplement = new AggressionCatalyst();
                    break;
                case "HealthCatalyst":
                    suplement = new HealthCatalyst();
                    break;
                case "PowerCatalyst":
                    suplement = new PowerCatalyst();
                    break;
                default:
                    base.ExecuteAddSupplementCommand(commandWords);
                    break;
            }
            var unit = this.GetUnit(commandWords[2]);
            if (unit != null)
            {
                unit.AddSupplement(suplement);
            }
        }
    }
}

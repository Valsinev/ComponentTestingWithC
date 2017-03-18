using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Marine : Human
    {
        public Marine(string id) : base(id)
        {
            this.AddSupplement(new WeaponrySkill());
        }
        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);

            var selectAllWithLessPower = attackableUnits.Where(u => u.Power <= this.Aggression);

            if (selectAllWithLessPower.Count() > 1)
            {
                foreach (var unit in selectAllWithLessPower)
                {

                    optimalAttackableUnit = selectAllWithLessPower.OrderByDescending(u => u.Health).FirstOrDefault();
                }
            }
            return optimalAttackableUnit;
        }
    }
}

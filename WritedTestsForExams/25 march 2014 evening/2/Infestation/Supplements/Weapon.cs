using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Weapon : Supplement, ISupplement
    {
        public Weapon()
            :base(0,0,0)
        {
            this.AggressionEffect = aggEffectAdd;
            this.PowerEffect = powEffectAdd;
        }

        protected int powEffectAdd { get; set; }
        protected int aggEffectAdd { get; set; }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.aggEffectAdd += 3;
                this.powEffectAdd += 10;
            }
        }
    }
}

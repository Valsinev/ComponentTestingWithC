using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class InfestationSpores : ISupplement
    {
        
        private int AggressionEffectConst = 20;
        private int PowerEffectConst = -1;

        public int AggressionEffect
        {
            get
            {
                return AggressionEffectConst;
            }
        }

        public int HealthEffect { get; private set; }

        public int PowerEffect
        {
            get
            {
                return PowerEffectConst;
            }
        }

        public void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement.GetType().Name == this.GetType().Name)
            {
                this.AggressionEffectConst = 0;
                this.PowerEffectConst = 0;
            }
        }
    }
}

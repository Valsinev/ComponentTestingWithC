using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class PowerCatalyst : Supplement, ISupplement
    {
        private const int PowerEffectChange = 3;

        public PowerCatalyst()
            :base(0,0, PowerEffectChange)
        {
        }
    }
}

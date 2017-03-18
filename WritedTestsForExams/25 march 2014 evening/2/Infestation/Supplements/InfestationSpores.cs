namespace Infestation
{
    public class InfestationSpores : ISupplement
    {
        private int aggressionEffectConst = 20;
        private int powerEffectConst = -1;

        public int AggressionEffect
        {
            get
            {
                return this.aggressionEffectConst;
            }
        }

        public int HealthEffect { get; private set; }

        public int PowerEffect
        {
            get
            {
                return this.powerEffectConst;
            }
        }

        public void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement.GetType().Name == this.GetType().Name)
            {
                this.aggressionEffectConst = 0;
                this.powerEffectConst = 0;
            }
        }
    }
}

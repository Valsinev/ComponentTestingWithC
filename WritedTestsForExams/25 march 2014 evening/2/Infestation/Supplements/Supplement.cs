namespace Infestation
{
    public abstract class Supplement : ISupplement
    {
        private int aggressionEffect;
        private int healthEffect;
        private int powerEffect;

        public Supplement(int aggressionEffect, int healthEffect, int powerEffect)
        {
            this.AggressionEffect = aggressionEffect;
            this.HealthEffect = healthEffect;
            this.PowerEffect = powerEffect;
        }

        public int AggressionEffect
        {
            get
            {
                return this.aggressionEffect;
            }

            protected set
            {
                this.aggressionEffect = value;
            }
        }

        public int HealthEffect
        {
            get
            {
                return this.healthEffect;
            }

            protected set
            {
                this.healthEffect = value;
            }
        }

        public int PowerEffect
        {
            get
            {
                return this.powerEffect;
            }

            protected set
            {
                this.powerEffect = value;
            }
        }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
        }
    }
}
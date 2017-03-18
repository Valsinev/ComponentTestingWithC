namespace Infestation
{
    public class Weapon : Supplement, ISupplement
    {
        public Weapon()
            : base(0, 0, 0)
        {
            this.AggressionEffect = this.AggEffectAdd;
            this.PowerEffect = this.PowEffectAdd;
        }

        protected int PowEffectAdd { get; set; }

        protected int AggEffectAdd { get; set; }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.AggEffectAdd += 3;
                this.PowEffectAdd += 10;
            }
        }
    }
}

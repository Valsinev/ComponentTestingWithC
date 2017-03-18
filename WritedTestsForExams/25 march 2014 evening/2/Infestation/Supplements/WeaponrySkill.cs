namespace Infestation
{
    using System;

    public class WeaponrySkill : ISupplement
    {
        public int AggressionEffect { get; protected set; }

        public int HealthEffect { get; protected set; }

        public int PowerEffect { get; protected set; }

        public void ReactTo(ISupplement otherSupplement)
        {
            // Weapon
            throw new NotImplementedException();
        }
    }
}

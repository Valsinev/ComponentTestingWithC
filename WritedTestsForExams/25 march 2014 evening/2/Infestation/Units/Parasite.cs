namespace Infestation
{
    public class Parasite : InfestUnit
    {
        private const int ParasitePower = 1;
        private const int ParasiteHealth = 1;
        private const int ParasiteAggression = 1;

        public Parasite(string id)
            : base(id, UnitClassification.Biological, Parasite.ParasiteHealth, Parasite.ParasitePower, Parasite.ParasiteAggression)
        {
        }
    }
}

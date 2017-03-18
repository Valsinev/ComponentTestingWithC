namespace Infestation
{
    public class AggressionCatalyst : Supplement, ISupplement
    {
        private const int AggressionEffectChange = 3;

        public AggressionCatalyst()
            : base(AggressionEffectChange, 0, 0)
        {
        }
    }
}

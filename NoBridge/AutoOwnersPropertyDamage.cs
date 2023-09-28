namespace NoBridge
{
    public class AutoOwnersPropertyDamage : PropertyDamage
    {
        public AutoOwnersPropertyDamage(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return base.GetPremium() * 0.95m;
        }
    }
}
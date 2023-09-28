namespace NoBridge
{
    public class SafeDriverPropertyDamage : PropertyDamage
    {
        public SafeDriverPropertyDamage(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return base.GetPremium() * 0.90m;
        }
    }
}
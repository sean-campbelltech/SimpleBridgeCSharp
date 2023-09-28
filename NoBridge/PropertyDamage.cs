namespace NoBridge
{
    public class PropertyDamage : CarInsurance
    {
        public PropertyDamage(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return 60.00m;
        }
    }
}
namespace WithBridge
{
    public class PropertyDamage : CarInsurance
    {
        public PropertyDamage(int year, string make, string model, Discount discount) : base(year, make, model, discount)
        {
        }

        protected override decimal GetPremium()
        {
            return 60.00m;
        }
    }
}
namespace WithBridge
{
    public class ThirdParty : CarInsurance
    {
        public ThirdParty(int year, string make, string model, Discount discount) : base(year, make, model, discount)
        {
        }

        protected override decimal GetPremium()
        {
            return 50.00m;
        }
    }
}
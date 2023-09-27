namespace WithBridge
{
    // RefinedAbstraction2
    public class ThirdPartyCarInsurance : CarInsurance
    {
        public ThirdPartyCarInsurance(
            int year, string make, string model, Discount discount) : base(year, make, model, discount)
        {
        }

        protected override decimal GetPremium()
        {
            return 50.00m;
        }
    }
}
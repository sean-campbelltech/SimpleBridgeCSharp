namespace WithBridge
{
    public class Comprehensive : CarInsurance
    {
        public Comprehensive(int year, string make, string model, Discount discount) : base(year, make, model, discount)
        {
        }

        protected override decimal GetPremium()
        {
            return 165.00m;
        }
    }
}
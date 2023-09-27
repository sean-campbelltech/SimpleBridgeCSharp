namespace WithBridge
{
    // RefinedAbstraction1
    public class ComprehensiveCarInsurance : CarInsurance
    {
        public ComprehensiveCarInsurance(int year, string make, string model, Discount discount) : base(year, make, model, discount)
        {
        }

        protected override decimal GetPremium()
        {
            return 165.00m;
        }
    }
}
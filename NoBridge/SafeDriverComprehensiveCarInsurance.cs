namespace NoBridge
{
    public class SafeDriverComprehensiveCarInsurance : ComprehensiveCarInsurance
    {
        public SafeDriverComprehensiveCarInsurance(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return base.GetPremium() * 0.90m;
        }
    }
}
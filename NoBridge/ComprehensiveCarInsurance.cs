namespace NoBridge
{
    public class ComprehensiveCarInsurance : CarInsurance
    {
        public ComprehensiveCarInsurance(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return 165.00m;
        }
    }
}
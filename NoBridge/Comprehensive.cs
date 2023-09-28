namespace NoBridge
{
    public class Comprehensive : CarInsurance
    {
        public Comprehensive(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return 165.00m;
        }
    }
}
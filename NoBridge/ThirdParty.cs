namespace NoBridge
{
    public class ThirdParty : CarInsurance
    {
        public ThirdParty(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return 50.00m;
        }
    }
}
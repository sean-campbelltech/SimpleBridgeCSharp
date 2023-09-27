namespace NoBridge
{
    public class ThirdPartyCarInsurance : CarInsurance
    {
        public ThirdPartyCarInsurance(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return 50.00m;
        }
    }
}
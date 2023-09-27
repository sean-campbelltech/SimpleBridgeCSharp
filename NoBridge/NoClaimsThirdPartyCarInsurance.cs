namespace NoBridge
{
    public class NoClaimsThirdPartyCarInsurance : ThirdPartyCarInsurance
    {
        public NoClaimsThirdPartyCarInsurance(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return base.GetPremium() * 0.85m;
        }
    }
}
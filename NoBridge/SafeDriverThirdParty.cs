namespace NoBridge
{
    public class SafeDriverThirdParty : ThirdParty
    {
        public SafeDriverThirdParty(int year, string make, string model) : base(year, make, model)
        {
        }

        public override decimal GetPremium()
        {
            return base.GetPremium() * 0.90m;
        }
    }
}
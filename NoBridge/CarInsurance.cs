namespace NoBridge
{
    public abstract class CarInsurance
    {
        public CarInsurance(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public int Year { get; }
        public string Make { get; }
        public string Model { get; }

        public abstract decimal GetPremium();
    }
}
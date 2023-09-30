namespace WithBridge
{
    // ConcreteImplementorB
    public class NoClaimsDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 15;
        }
    }
}
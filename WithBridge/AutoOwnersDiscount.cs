using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WithBridge
{
    // ConcreteImplementorC
    public class AutoOwnersDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 5;
        }
    }
}
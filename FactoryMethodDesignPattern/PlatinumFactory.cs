using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class PlatinumFactory : CreditCardFactory
    {
        // The signature of the method uses the abstract product CreditCard type,
        // Even though the concrete Platinum product is returned from the method.
        // This way the Abstract Creator CreditCardFactory can stay independent of concrete product classes.
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
}

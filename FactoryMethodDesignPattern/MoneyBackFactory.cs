using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class MoneyBackFactory : CreditCardFactory
    {
        // The signature of the method still uses the abstract product CreditCard type
        // Even though the concrete MoneyBack product is actually returned from the method.
        // This way the Creator can stay independent of concrete product classes.
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }
}

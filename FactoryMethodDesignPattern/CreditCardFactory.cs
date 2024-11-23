using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            CreditCard creditCard = this.MakeProduct();
            //Return the Object to the Client
            return creditCard;
        }
    }
}

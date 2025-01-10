using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDelegate
{
    public class NormalUser : IUser
    { 
        public string Name { get; set; }
        public ShoppingCartModel ShoppingCart { get; set; }

        public decimal GetDiscountprice(decimal totalprice)
        {
            if (ShoppingCart.Item.Count > 5)
            {
                return totalprice * (1 - 30M);

            }
            else
            {
                return totalprice;
            }
        }

        
             
             
        
        

    }
}

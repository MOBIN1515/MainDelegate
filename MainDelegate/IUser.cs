using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDelegate
{
    public interface IUser
    {
        string Name { get; set; }
        ShoppingCartModel ShoppingCart { get; set; }
        decimal GetDiscountprice(decimal totalprice);


    }
}

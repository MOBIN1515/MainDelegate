using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDelegate
{
     public class ShoppingCartModel
    {
     
        public List<ProductModel> Item { get; set; } = new List<ProductModel>();
        public delegate decimal ComouteDiscoutedPrice(decimal totalPrice);
        public delegate void PrintDiscoutedValue(decimal totalPrice, decimal finalPrice);
        public decimal GetFinalPrice(Func<List<ProductModel>, decimal> Calculater,
         
           ComouteDiscoutedPrice discoutedpricecalcuter, PrintDiscoutedValue printDiscoutedValue)
        {
            decimal total = Calculater(Item);
           decimal dicountedvalue = discoutedpricecalcuter(total);
            printDiscoutedValue(total, dicountedvalue);
            return dicountedvalue;


        }




    }
}

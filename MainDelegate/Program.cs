using System.Threading.Channels;
using System.Xml.Linq;

namespace MainDelegate
{
     class Program
    {
        static void Main(string[] args)
        {
            IUser normalUser = new NormalUser() { Name = "Mobin" };
            IUser goldenUser = new GoldenUser() { Name = "Radin" };
            normalUser.ShoppingCart = FileShoppingCart();
            goldenUser.ShoppingCart = FileShoppingCart();

            decimal NormalUserFinalPrice = normalUser.ShoppingCart.GetFinalPrice(Computetotatal,
            normalUser.GetDiscountprice, (total, discounted) => Console.WriteLine(
                $"your discounted is {(total-discounted)}:c2"));




            decimal GoldenuserFinalPrice = goldenUser.ShoppingCart.GetFinalPrice(Computetotatal,
                goldenUser.GetDiscountprice ,(total, discounted) => Console.WriteLine(
                $"your discounted is {(total - discounted)}:c2"));
                

            Console.WriteLine($"Normal User :{NormalUserFinalPrice:c2}");
            Console.WriteLine($"Golden User :{GoldenuserFinalPrice:c2}");
            Console.ReadKey();


            static decimal Computetotatal(List<ProductModel> items)
            {
                return items.Sum(x => x.price);
            }

            static ShoppingCartModel FileShoppingCart()
            {
                ShoppingCartModel Cart= new ShoppingCartModel();
                Cart.Item.Add(new ProductModel() { Name="T-Shirt1",price =10.5M});
                Cart.Item.Add(new ProductModel() { Name = "T-Shirt2", price = 15.3M});
                Cart.Item.Add(new ProductModel() { Name = "Pants1", price =21M});
                Cart.Item.Add(new ProductModel() { Name = "Pants2", price = 18M });
                return Cart;
            }

        }
    }
}

namespace linq_prac
{
    public class Linq
    {
        public int id { get; set; }
        public string product { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Linq> list = new List<Linq>()
            {
                new Linq {id=1,product="laptop",brand="dell", price=45000, quantity=5},
                new Linq {id=2,product="mobile",brand="realme", price=15200, quantity=3},
                new Linq {id=3,product="tab",brand="lenovo", price=20000, quantity=2},
                new Linq {id=4,product="headset",brand="boat", price=500, quantity=19},
                new Linq {id=5,product="tv",brand="realme", price=45700, quantity=1}
            };

     





            //foreach (Linq item in query)
            //{
            //    Console.WriteLine($"{item.id} {item.product} {item.price} {item.brand} {item.quantity}");
            //}
        }
    }
}
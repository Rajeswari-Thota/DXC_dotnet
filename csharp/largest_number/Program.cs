namespace largest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int n2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            int n3= Convert.ToInt32(Console.ReadLine());
            if(n1>n2 && n1 > n3) 
            {
                Console.WriteLine("first number is greater");
            }
            else if(n2>n3) 
            {
                Console.WriteLine("second number is greater");
            }
            else
            {
                Console.WriteLine("third number is greater");
            }
        }
    }
}
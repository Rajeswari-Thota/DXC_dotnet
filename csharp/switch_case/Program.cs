namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int n2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose any  operator");
            
            char ch =Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '+':
                    {
                        Console.WriteLine("result is " + (n1 + n2));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("result is " + (n1 - n2));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine("result is " + (n1 * n2));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine("result is " + (n1 / n2));
                        break;
                    }
                case '%':
                    {
                        Console.WriteLine("result is " + (n1 % n2));
                        break;
                    }
            }

            }
    }
}
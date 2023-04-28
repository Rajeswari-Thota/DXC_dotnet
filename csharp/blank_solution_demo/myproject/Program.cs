using ClassLibrary1;

namespace myproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter an op");
            char ch =Convert.ToChar(Console.ReadLine());
            calculator calc=new calculator();
            switch(ch)
            {
                case '+':
                    {
                        Console.WriteLine(($"The Result is: {calc.Sum(n1,n2)}"));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(($"The Result is: {calc.Sub(n1, n2)}"));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(($"The Result is: {calc.Mul(n1, n2)}"));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(($"The Result is: {calc.Div(n1, n2)}"));
                        break;
                    }
                case '%':
                    {
                        Console.WriteLine(($"The Result is: {calc.Mod(n1, n2)}"));
                        break;
                    }
            }
            Console.ReadKey();
            
        }
    }
}
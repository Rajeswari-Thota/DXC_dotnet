namespace simple_intrest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter principle amount");
            double P= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter no.of years");
            double T= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter rate of interest");
            double R= Convert.ToDouble(Console.ReadLine());
            double SI = (P * T * R) / 100;
            Console.WriteLine("simple interest is "+ SI);

        }
    }
}
namespace celcius_2_farenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter temperature");
            int c=Convert.ToInt32(Console.ReadLine());
            int f = (c * (9 / 5)) + 32;
            Console.WriteLine("the temperature in farenheit is "+f);
        }
    }
}
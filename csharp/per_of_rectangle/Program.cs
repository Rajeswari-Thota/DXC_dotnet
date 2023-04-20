namespace per_of_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of the rectangle");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of the rectangle");
            double b = Convert.ToDouble(Console.ReadLine());
            double p = 2 * (l + b);
            Console.WriteLine("perimeter of the rectangle is " + p);
        }
    }
}
char n='y',u;
do
{
    Console.WriteLine("Enter the temperature in degree celsius");
    int c = Convert.ToInt32(Console.ReadLine());
    double f = (c * 9) / 5 + 32;
    Console.WriteLine($"Temperature (celsius)={c}");
    Console.WriteLine($"Temperature (farenheit)= "+f);
    Console.WriteLine("Do you wish to continue(y/n)?");
    u = Convert.ToChar(Console.ReadLine());

} while (u==n);

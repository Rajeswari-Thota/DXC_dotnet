int c = 0;
Console.WriteLine("Sr.no \t Temperature in celsius \t Temperature in farenheit ");
for (int i = 1; i <= 10; i++)
{
    
    int f = (c * 9) / 5 + 32;
    
    Console.WriteLine($"{i} \t {c} \t\t\t\t {f}");
    c += 10;


}

Console.WriteLine("Enter a 5 digit number:");
int n=Convert.ToInt32(Console.ReadLine());
int sum = 0,r;
while (n > 0)
{
    r = n % 10;
    sum += r;
    n = n / 10;
}
Console.WriteLine($"sum of digits is {sum}");
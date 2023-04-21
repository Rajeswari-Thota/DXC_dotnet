int c = 0;
for(int i = 1; i <= 10; i++)
{
    
    int f = (c * 9) / 5 + 32;
    Console.WriteLine($"{i}           Temperature in celsius is {c}       Temperature in farenheit is {f}");
    c += 10;


}

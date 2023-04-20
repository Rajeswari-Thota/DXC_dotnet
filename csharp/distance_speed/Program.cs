// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the distance of the journey in km");
int d= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the speed of the journey in km/hr");
int s= Convert.ToInt32(Console.ReadLine());
double time = d/s;
Console.WriteLine("Total time taken for the journey in hours: "+time);


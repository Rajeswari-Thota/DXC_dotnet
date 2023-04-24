Console.WriteLine("enter the length of an array:");
int n=Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int sum = 0;
Console.WriteLine("enter the elements:");
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < n; i++)
{
    sum = sum + arr[i];
};
double avg = (double)sum / n;
Console.WriteLine($"average of the elements in an array is {avg}");
int[] arr = { 7,8,9,6,7,5,4,6,3,8,9,2,2,4,1,3 };
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
            break;
        }
    }
}

Console.WriteLine("Number of duplicates: " + count);

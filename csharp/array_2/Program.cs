int[] arr = new int[] {7,7,7,7,8,8,8,5,5,5,5,6,6,6,6,6};
int n=arr.Length;
int maxcount = 0;
int freq_ele = 0;
for (int i = 0; i < n; i++)
{
    int count = 0;
   for (int j = 0; j < n; j++)
        {
            if (arr[i] == arr[j])
                {
                    count++;
                }
        }

    if (count > maxcount)
        {
            maxcount = count;
            freq_ele = arr[i];
        }
}

Console.WriteLine(freq_ele);

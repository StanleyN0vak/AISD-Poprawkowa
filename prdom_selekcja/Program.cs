int[] a = { 3, 2, 4, 3, 1, 2, 0 };
int temp = 0;
int temp2 = 0;
int temp3 = 0;


for (int i = 0; i < a.Length; i++)
{
    temp = a[i];
    for (int j = i; j < a.Length; j++)
    {
        if (a[j] < temp)
        {
            temp = a[j];
            temp2 = j;
        }
    }
    temp3 = a[i];
    a[i] = temp;
    a[temp2] = temp3;
}

foreach (int i in a)
{
    Console.WriteLine(i);
}

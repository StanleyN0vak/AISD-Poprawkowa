int[] tab = { 9, 8, 5, 3, 2, 6, 7, 1, 4 };
//int half = tab.Length / 2;

//int[] firstHalf = tab.Take(half).ToArray();
//int[] secondHalf = tab.Skip(half).ToArray();

List<int> wynik = new List<int>();
List<int[]> temp = new List<int[]>();

void SelectM(int[] table)
{
    if (table.Length <= 1)
        return;

    int half = table.Length / 2;
    int[] left = new int[half];
    int[] right = new int[table.Length - half];

    for (int i = 0; i < half; i++)
    {
        left[i] = table[i];
    }

    for (int i = half; i < table.Length; i++)
    {
        right[i - half] = table[i];
    }

    SelectM(left);
    SelectM(right);
    Merge(table, left, right);
}

void Merge(int[] result, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    while (i <left.Length && j < right.Length)
    {
        if (left[i] < right[j])
        {
            result[k++] = left[i++];
        }
        else
        {
            result[k++] = right[j++];
        }
    }

    while (i < left.Length)
    {
        result[k++] = left[i++];
    }

    while (j < right.Length)
    {
        result[k++] = right[j++];
    }
}

SelectM(tab);
foreach (int i in tab)
{
    Console.WriteLine(i);
}
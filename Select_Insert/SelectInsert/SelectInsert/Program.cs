int[] tab = { 6, 5, 3, 1, 8, 7, 2, 4 }; int temp1 = 0, x = 0, j = 0;

for (int i = 1; i < tab.Length; i++)
{
    j = i - 1;
    x = i;
    while (j >= 0 && tab[x] < tab[j])
    {
        temp1 = tab[x];
        tab[x] = tab[j];
        tab[j] = temp1;
        j--; x--;
    }
}

foreach (int i in tab)
{
    Console.WriteLine(i);
}
int[] tab = { 9, 1, 6, 8, 4, 3, 2, 0 }; int temp1 = 0; int temp2 = 0; bool done = false;

do
{
    done = false;
    for (int i = 0; i < tab.Length; i++)
    {
        temp1 = tab[i];
        for (int j = i; j < tab.Length; j++)
        {
            if (temp1 > tab[j])
            {
                temp2 = j;
                done = true;
                break;
            }
        }
        if (done)
        {
            tab[i] = tab[temp2];
            tab[temp2] = temp1;
        }
    }
} while (done);

foreach (int i in tab)
{
    Console.WriteLine(i);
}
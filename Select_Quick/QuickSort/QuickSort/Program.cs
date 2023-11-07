int[] tab = { 9, 2, 6, 4, 1, 5, 7, 8, 0, 3 };
int p = tab.Length;

void SelectQ(int[] tabela, int lewy, int prawy)
{
    if (lewy < prawy)
    {
        int pi = partition(tabela, lewy, prawy - 1);
        SelectQ(tabela, lewy, pi);
        SelectQ(tabela, pi + 1, prawy);
    }    
}

int partition(int[] tabela, int lewy, int prawy)
{
    int pivot = tabela[lewy];
    int i = lewy, j = prawy, temp = 0;

    while (true)
    {
        while (tabela[i] < pivot)
        {
            i++;
        }

        while (tabela[j] > pivot)
        {
            j--;
        }
        if (i < j)
        {
            temp = tabela[i];
            tabela[i] = tabela[j];
            tabela[j] = temp;
            i++;
            j--;
        }
        else
        {
            return j;
        }
    }
}

void copy(int[] oryg, int[] nowy)
{
    for (int i = 0; i < oryg.Length; i++)
    {
        nowy[i] = oryg[i];
    }
}

int[] test = new int[tab.Length];
copy(tab, test);

SelectQ(tab, 0, p);

foreach (int i in tab)
{
    Console.WriteLine(i);
}

Console.WriteLine(" ");
Random random = new Random();
int los = random.Next();
Console.WriteLine(los);

Console.WriteLine(" ");
foreach(int i in test)
{
    Console.WriteLine(i);
}
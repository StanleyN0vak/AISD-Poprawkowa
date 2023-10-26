int[] a = { 1, 2, 3 }; int[] b = { 4, 7 }; List<int> wynik = new List<int>(); List<int> wynikRev = new List<int>(); int temp = 0; bool one = false;

Array.Reverse(a);
Array.Reverse(b);

for (int i = 0; i < b.Length; i++ )
{
        if ((a[i] + b[i]) < 10 && one == false)
            wynik.Add(a[i] + b[i]);
        else if(one)
        {
            wynik[wynik.Count-1] += a[i] + b[i];
            one = false;
            if (wynik[wynik.Count - 1] > 9)
            {
                wynik[wynik.Count - 1] %= 10;
                one = true;
            }
        }
        else
        {
            temp = (a[i] + b[i]) % 10;
            wynik.Add(temp);
            wynik.Add(1);
            one = true;
            
        }
}

if (a.Length > b.Length)
{
    for (int i = b.Length; i < a.Length; i++)
    {
        wynik.Add(a[i]);
    }
}

for (int i = wynik.Count - 1; i >= 0; i--)
{
    wynikRev.Add(wynik[i]);
}


/*
foreach (int x in a.Reverse())
{
    foreach (int y in b.Reverse())
    {
        wynik.Add(x + y);
    }
}

*/
foreach (int i in wynikRev)
{
    Console.WriteLine(i);
}

/*
wynik.ToList().ForEach((x) => Console.WriteLine(x));

List<int> lista = (from x in a
            where x > 2
            select x).ToList();
*/
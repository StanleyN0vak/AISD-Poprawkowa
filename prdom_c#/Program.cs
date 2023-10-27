int[] a = { 1, 2, 3 };
int[] b = { 4, 5, 6 };
List<int> wynik = new List<int>();
List<int> wynikRev = new List<int>();
bool plus;
plus = false;

Array.Reverse(a);
Array.Reverse(b);

if (a.Length < b.Length)
{
    int[] b2 = b;
    b = a;
    a = b2;
}

for(int i = 0; i < b.Length; i++)
{
    if ((a[i] + b[i]) < 10 && plus == false)
    {
        wynik.Add(a[i] + b[i]);
    }
    else if(plus == true)
    {
        if((a[i] + b[i] + 1) > 9)
        {
            wynik.Add((a[i] + b[i] + 1)%10);
        }
        else
        {
            wynik.Add(a[i] + b[i] + 1);
            plus = false;
        }
    }
    else
    {
        plus = true;
        wynik.Add((a[i] + b[i] + 1) % 10);
        wynik.Add(1);
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

foreach (int i in wynikRev)
{
    Console.WriteLine(i);
}

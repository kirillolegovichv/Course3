Console.Write(" Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int odd = 0;
int even = 0;
int j = 0;

for (int i = 1; i < N; i++)
{
    j = i;
    even = 0;
    odd = 0;
    while (j > 0)
    {
        if ((j % 10) % 2 == 0)  even++;
        else odd++;
        j /= 10;
    }
    if (even > odd) Console.WriteLine(i);
}

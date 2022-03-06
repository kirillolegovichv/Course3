Console.Write(" Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int tmp = 0;

for (int i = 1; i < N; i++)
{
    tmp = i;
    int odd = 0;
    int even = 0;
    while (tmp > 0)
    {
        if ((tmp % 10) % 2 == 0 && (tmp % 10) != 0)
        {
            even += tmp;
        }
        else
        {
            odd += tmp;
        }
        tmp /= 10;
    }
    if (even > odd)
    {
        Console.WriteLine(i);
    }
}

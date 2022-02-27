Console.Write(" Enter А: ");
int A = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 1; i < A; i++)
{
    if (A % i == 0)
    {
        result = i;
    }
}

Console.WriteLine(result);

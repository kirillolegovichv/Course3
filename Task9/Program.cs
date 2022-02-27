Console.Write(" Enter А: ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (A > 0)
{
    if (A % 2 != 0)
    {
        A /= 10;
        count++;
    }
    else A /= 10;
}
Console.WriteLine($"Count of odd: {count}");
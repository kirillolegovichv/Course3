Console.Write(" Enter А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter B: ");
int B = Convert.ToInt32(Console.ReadLine());

while (A != 0 && B != 0)
{
    if (A > B) A %= B;
    else B %= A;
}

Console.WriteLine($"NOD = {A + B}");
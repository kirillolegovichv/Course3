Console.Write(" Enter А: ");
int A = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 1; i * i < A; i++)
{
    result = i;
}

Console.WriteLine($" Result: {result}");
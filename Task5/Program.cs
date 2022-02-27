Console.Write(" Enter А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter B: ");
int B = Convert.ToInt32(Console.ReadLine());
double result = 0;

for (int i = A; i < B; i++)    if (i % 7 == 0)    result += i;

Console.WriteLine($"Result {result}");
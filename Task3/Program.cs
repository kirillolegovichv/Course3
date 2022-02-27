Console.Write(" Enter А: ");
int A = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 1; i < A; i++)    if (i * i < A)   result += 1; 

Console.WriteLine($" Result: {result}");
Console.Write(" Введите число А: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write(" Введите число B: ");
double B = Convert.ToDouble(Console.ReadLine());
double result = 1;

for (int i = 1; i <= B; i++)
{
    result *= A;
}

Console.WriteLine($" A ^ B = {result} ");
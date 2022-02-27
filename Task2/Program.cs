Console.Write(" Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

for (int i = A; i <= 1000; i += A) Console.WriteLine(i);
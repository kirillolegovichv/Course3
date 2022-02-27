Console.Write(" Enter А: ");
int A = Convert.ToInt32(Console.ReadLine());

while(A > 0)
{
    Console.Write($"{A % 10}");
    A /= 10;
}
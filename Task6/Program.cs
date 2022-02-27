Console.Write(" Enter А: ");
int f = Convert.ToInt32(Console.ReadLine());
int A = 1;
int B = 1;
int next;
for (int i = 3; i <= f; i++)
{
    next = A + B;
    A = B;
    B = next;
}

Console.WriteLine($"N = {B}");
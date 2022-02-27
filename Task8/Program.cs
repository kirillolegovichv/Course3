Console.Write(" Enter : ");
int C = Convert.ToInt32(Console.ReadLine());
int A = 0;
int B = C;
int middle;

while (B - A != 1)
{
    middle = (B + A) / 2;
    if ((middle * middle * middle) > C) B = middle;
    else A = middle;

}
Console.WriteLine(A);
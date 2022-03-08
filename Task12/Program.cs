Console.Write(" Enter А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter B: ");
int B = Convert.ToInt32(Console.ReadLine());
string result = "НЕТ";


while (A > 0)
{
    int tmpForB = B;
    while (tmpForB > 0)
    {
        if (A % 10 == tmpForB % 10)
        {
            result = "ДА";
        }
        tmpForB /= 10;
    }
    A /= 10;
}

Console.WriteLine(result);
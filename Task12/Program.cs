Console.Write(" Enter А: ");
string A = Console.ReadLine();
Console.Write(" Enter B: ");
string B = Console.ReadLine();
string result = "";

for (int i = 0; i < A.Length; i++)
{
    for (int j = 0; j < B.Length; j++)
    {
        if (A[i] == B[j]) result = " Да ";
    }
}

if (result == "") Console.WriteLine(" Нет ");
else Console.WriteLine(result);
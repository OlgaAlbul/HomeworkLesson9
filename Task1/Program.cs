// Показать натуральные числа от M до N, N и M заданы

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers1(int M, int N)
{
    Console.Write($"{M}, ");
    if(M==N)
    Console.WriteLine("end");
    else PrintNumbers1(M-1,N);    
}

void PrintNumbers2 (int M, int N)
{
    if (N!=0)
    {
        PrintNumbers2( M, N-1);
        Console.Write($"{N}, ");
    }
}

int numberM = ReadInt("Enter number M: ");
int numberN = ReadInt("Enter number N: ");

if (numberM>numberN)
{
    PrintNumbers1(numberM, numberN);
}
else PrintNumbers2(numberM, numberN);
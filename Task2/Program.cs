// Найти сумму элементов от M до N, N и M заданы
int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int PrintSum1( int m, int n)
{
    int sum = n;
    if (m!=n)
    {
       sum = sum + PrintSum1(m, n+1);
    }
    return sum;
}
int PrintSum2( int m, int n)
{
    int sum = m;
    if (m!=n)
    {
       sum = sum + PrintSum2(m+1, n); 
    }
    return sum;
}

int numberM = ReadInt("Enter number M: ");
int numberN = ReadInt("Enter number N: ");

if (numberM>numberN)
{
    Console.WriteLine($"The sum of the numbers from {numberM} to {numberN} is equal to: {PrintSum1(numberM,numberN)}");
}
else
Console.WriteLine($"The sum of the numbers from {numberM} to {numberN} is equal to: {PrintSum2(numberM,numberN)}");

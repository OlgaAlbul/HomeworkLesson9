// Найти сумму цифр числа
int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int SumNumbers (int n)
{
    if (n<1) return 0;
    else return SumNumbers(n/10)+n%10;
}

int number = ReadInt("Enter the number: ");
Console.WriteLine($"The sum of the digits of the {number} is {SumNumbers(number)}");
// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
//Первые два элемента последовательности задаются пользователем.

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
void SumOfNumbers (int a, int b, int n)
{
   int value = 0;
    if (n > 0)
    {
        Console.Write(a + b + " ");
        value = a;
        a =b;
        b += value;
        SumOfNumbers(a, b, n-1);
    }
}

int element1 = ReadInt("Enter first element: ");
int element2 = ReadInt("Enter second element: ");
int numberN = ReadInt("Set how many numbers to output: ");

SumOfNumbers(element1, element2, numberN);

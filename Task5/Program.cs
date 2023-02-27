// Написать программу возведения числа А в целую степень B

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int Exponentiation( int a, int b)
{
    int expon = a;
    if (b!=0)
    {
        expon = expon*Exponentiation(a, b-1);
    }
    return expon;
}

int number = ReadInt("Enter the number: ");
int degree = ReadInt("Enter degree of number: ");

if (degree == 0)
{
    Console.WriteLine($"The number {number} to the power of {degree} is equal to 1");
}
else
Console.WriteLine($"The number {number} to the power of {degree} is equal to {Exponentiation(number,degree)}");

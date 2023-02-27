// Написать программу вычисления функции Аккермана
int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int Ackerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackerman(n - 1, 1);
    else
      return Ackerman(n - 1, Ackerman(n, m - 1));
}

int argumentN= ReadInt("Enter argument n");
int argumentM= ReadInt("Enter argument m");
Console.WriteLine ($"The value of the Ackerman function for the given arguments is {Ackerman(argumentN,argumentM)}");
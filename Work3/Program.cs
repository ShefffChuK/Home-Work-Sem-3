int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

void NumberPow(int number)
{
for (int i = 1; i <= number; i++)
{
System.Console.Write(Math.Pow(i, 3) + " ");
}
}

int number = ReadInt("Введите число: ");
NumberPow(number);
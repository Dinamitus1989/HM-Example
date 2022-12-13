Console.WriteLine("Введите число N");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = Math.Abs(number);
}

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}

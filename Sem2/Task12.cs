Console.WriteLine("Введите число:");

int number = int.Parse(Console.ReadLine()!);

if (number <= 0 || number > 7)
{
    Console.WriteLine("неверный ввод");
}

else if (number > 5 && number < 8)

{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
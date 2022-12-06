Console.WriteLine("Введите число:");

int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = number * -1;
}
if (number < 100 && number > -100)
{
    Console.WriteLine("третьего числа нет");
}
else
{
    while (number > 999)

    number = number / 10;
    int chislo3 = number % 10;


    Console.WriteLine(chislo3);
}

Console.WriteLine("Введите трехзначное число:");


int number = int.Parse(Console.ReadLine()!);
if (number < 1000)
{
    int result = number / 10;
    int SecondDigit = result % 10;

    Console.WriteLine(SecondDigit);
}

else
{
    Console.WriteLine("Неверный ввод");

}
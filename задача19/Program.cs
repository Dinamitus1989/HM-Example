Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);

if( 10000 <= number && number <= 99999 )
{
    int Digit1 = number / 10000;
    int Digit2 = number / 1000 % 10;
    int Digit4 = number / 10 % 10;
    int Digit5 = number % 10;
    

    if(Digit1 == Digit5 && Digit2 == Digit4)

    {
        Console.WriteLine("Да.Число является палиндромом");

    }

    else
    {
        Console.WriteLine("Нет.Число не является палиндромом");
    }

}else
{
    Console.WriteLine("Неверный ввод.Введите пятизначное число");
}

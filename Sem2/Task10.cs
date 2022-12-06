Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine()!);

int result = number / 10;
int SecondDigit = result % 10;

Console.WriteLine(SecondDigit);

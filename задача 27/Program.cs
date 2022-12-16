Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);


Console.WriteLine(SumDigits(number1));

int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
       
    }
    return sum;
}

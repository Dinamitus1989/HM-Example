Console.WriteLine("Введите два числа");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

int result = Power(number1, number2);
Console.WriteLine(result);

int Power(int a, int b)
{
    int mult = a;
    for (int i = 1; i < b; i++)
    {
        mult = mult * a;
    }
    return mult;
}
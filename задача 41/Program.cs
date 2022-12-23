Console.WriteLine("Введите количество чисел");
int numberCount = int.Parse(Console.ReadLine()!);

Console.WriteLine(CountPositiveNumbers(numberCount));

int CountPositiveNumbers(int numberCount)
{
    int counter = 0;
    for (int i = 0; i < numberCount; i++)
    {
        int CurrentNumber = int.Parse(Console.ReadLine()!);

        if (IsPositiveNumbers(CurrentNumber))
        {
            counter++;
        }

    }
    return counter;
}

bool IsPositiveNumbers(int number)
{
    return number > 0;

}
Console.WriteLine("Введите размер массива");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите min");
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите max");
int number3 = int.Parse(Console.ReadLine()!);

int[] array = GenArray(number1, number2, number3);


for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int[] GenArray(int a, int b, int c)
{
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(b, c + 1);
    }

return array;

}
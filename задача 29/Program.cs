Console.WriteLine("Введите размер массива");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите min");
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите max");
int number3 = int.Parse(Console.ReadLine()!);


int[] Array = GenArray(number1, number2, number3);
PrintArray(Array);

int[] GenArray(int n, int min, int max)
{
    int[] array = new int[n];
 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
 
    return array;
}
 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
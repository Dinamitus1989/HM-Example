Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] mainMatrix = Create2DArray(m, n, -5, 10);

Print2DArray(mainMatrix);

Console.WriteLine();

Average(mainMatrix);




int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}



void Print2DArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void Average(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ += matrix[i, j];
        }
        double Average = Math.Round(summ / matrix.GetLength(0), 2);
        Console.Write(Average);
        Console.Write("   ");
    }
}
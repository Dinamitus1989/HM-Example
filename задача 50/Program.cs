Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] mainMatrix = Create2DArray(m, n, -5, 10);

Print2DArray(mainMatrix);


Console.WriteLine("Введите значение элемента i");
int i = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение элемента j");
int j = int.Parse(Console.ReadLine()!);


SearchElement(mainMatrix, i, j);




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

void SearchElement(int[,] mainMatrix, int i, int j)
{
if (0 <= i && i < mainMatrix.GetLength(0))
    {
        if (0 <= j && j < mainMatrix.GetLength(1))
        {
            Console.WriteLine(mainMatrix[i, j]);
        }
        else Console.WriteLine("Такого элемента не существует");
    }
    else Console.WriteLine("Такого элемента не существует");
}

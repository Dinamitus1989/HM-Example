Console.WriteLine("Введите число");
string A = Console.ReadLine()!;

int ParsedInputA = int.Parse(A);

for (int i = 0; i <= ParsedInputA; i++)
{
    if (i % 2 == 0) 
    Console.WriteLine(i);

}
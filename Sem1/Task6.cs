Console.WriteLine("Введите число");
string A = Console.ReadLine()!;

int ParsedInputA = int.Parse(A);


if (ParsedInputA % 2 == 0)

{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
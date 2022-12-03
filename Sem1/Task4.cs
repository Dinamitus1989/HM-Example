Console.WriteLine("Введите числа");
string A = Console.ReadLine()!;
string B = Console.ReadLine()!;
string C = Console.ReadLine()!;
int ParsedInputA = int.Parse(A);
int ParsedInputB = int.Parse(B);
int ParsedInputC = int.Parse(C);
int max = ParsedInputA;
if (ParsedInputA > max) max = ParsedInputA;
if (ParsedInputB > max) max = ParsedInputB;
if (ParsedInputC > max) max = ParsedInputC;

Console.WriteLine(max);
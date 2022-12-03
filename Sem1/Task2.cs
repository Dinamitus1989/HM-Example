Console.WriteLine("Введите числа");
string A = Console.ReadLine()!;
string B = Console.ReadLine()!;
int ParsedInputA = int.Parse(A);
int ParsedInputB = int.Parse(B);

if(ParsedInputA > ParsedInputB)
{
    Console.Write("max=");
    Console.WriteLine(A);
}

else
{
    Console.Write("max=");
    Console.Write(B);

}
Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine()!);

double[] CrossPoint = GetCrossPoint(b1, k1, b2, k2);

Console.WriteLine(CrossPoint[0]);
Console.WriteLine(CrossPoint[1]);


double[] GetCrossPoint(double b1, double k1, double b2, double k2)

{

    double[] result = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    result[0] = x;
    result[1] = y;

    return result;



}

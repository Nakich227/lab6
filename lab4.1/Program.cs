void factorial(double nn, out double y)
{
    y = 1;
    for (int i = 1; i <= nn; i++)
    {
        y =y * i;
    }
}
void stepen(double a, double j, out double y)
{
    y = 1;
    for (int i = 1; i <= j; i++)
    {
        y = y * a;
    }
}
Console.Write("введите x = ");
double x = double.Parse(Console.ReadLine());
Console.Write("введите y = ");
double y = double.Parse(Console.ReadLine());
Console.Write("введите n = ");
double n = double.Parse(Console.ReadLine());
Console.Write("введите m = ");
double m = double.Parse(Console.ReadLine());
Console.Write("ведите а = ");
double a = double.Parse(Console.ReadLine());
Console.Write("введите c = ");
double c = double.Parse(Console.ReadLine());
factorial(x, out double s1);
stepen(a,n, out double s2);
stepen(c, m, out double p1);
double f = p1 + s1 + y / (a * s2);
Console.WriteLine($"f = {f}");
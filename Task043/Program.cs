Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double getResultX(double b1, double b2, double k1, double k2)
{
    double x = (-b2 + b1)/(-k1 + k2);
    return x;
}

double getResultY(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

double x = getResultX(b1,b2,k1,k2);
double y = getResultY(b1,k1,x); 
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
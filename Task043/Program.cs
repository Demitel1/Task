Console.Clear();

double getUserValue(String message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getPointX(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1)/(-k1 + k2);
    return x;
}

double getPointY(double x, double b1, double k1)
{
    double y = k1 * x + b1;
    return y;
}

void PrintPoints(double x, double y)
{
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

double b1 = getUserValue("введите значение b1: ");
double k1 = getUserValue("введите число k1: ");
double b2 = getUserValue("введите значение b2: ");
double k2 = getUserValue("введите число k2: ");

double x = getPointX(b1,k1,b2,k2);
double y = getPointY(x,b1,k1);
PrintPoints(x,y);

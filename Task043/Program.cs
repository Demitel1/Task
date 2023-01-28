Console.Clear();

double getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

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

double k1 = getUserValue("Введите значение k1: ");
double b1 = getUserValue("Введите значение b1: ");
double k2 = getUserValue("Введите значение k2: ");
double b2 = getUserValue("Введите значение b2: ");
double x = getResultX(b1,b2,k1,k2);
double y = getResultY(b1,k1,x); 
Console.Write($"Пересечение двух прямых в точке с координатами X: {x}, Y: {y}");
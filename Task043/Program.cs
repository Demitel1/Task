int getUserValue(string message)
{
    int result = int.Parse(Console.ReadLine());
    return result;
}

 
double getX(double k1,double b1,double k2,double b2)
{
    var x = (b1 - b2) / (k1 - k2);
    return x;
}

double getY(double k1,double b1,double x)
{
    var y = k1 * x + b1;
    return y;
}

var k1 = getUserValue("Введите k1: ");
var b1 = getUserValue("Введите b1: ");
var k2 = getUserValue("Введите k2: ");
var b2 = getUserValue("Введите b2: ");
var x = getX(k1,b1,k2,b2);
var y = getY(k1,b1,x);

Console.WriteLine($"Пересечение прямых в точке: ({x};{y})");
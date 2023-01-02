Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getDistanceCoordinate(int userAx, int userAy, int userAz, int userBx, int userBy, int userBz)
{
    double result = Math.Sqrt(Math.Pow((userAx - userBx), 2) + Math.Pow((userAy - userBy), 2) + Math.Pow((userAz - userBz), 2));
    return result;
}

int userAx = getUserValue("Введите значение Ax: ");
int userAy = getUserValue("Введите значение Ay: ");
int userAz = getUserValue("Введите значение Az: ");

int userBx = getUserValue("Введите значение Bx: ");
int userBy = getUserValue("Введите значение By: ");
int userBz = getUserValue("Введите значение Bz: ");

double distance = getDistanceCoordinate(userAx, userAy, userAz, userBx, userBy, userBz);
Console.WriteLine($"Расстояние между точками A и B: {distance}");
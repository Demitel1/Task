Console.Clear();


int getUserValue(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Formula(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Formula(m - 1, 1);
    else
        return Formula(m - 1, Formula(m, n - 1));
}

int m = getUserValue("Введите M: ");
int n = getUserValue("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Formula(m, n)}");
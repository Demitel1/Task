Console.Clear();

int getUserValue(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int IntervalofNumbs(int n, int m)
{
    if (n == m)
        return n;
    else if (n < 1)
        {Console.WriteLine("Ввели не положительное число");}
    else
        {Console.Write($"{IntervalofNumbs(n, m + 1)}, ");}
    return m;
}

int n = getUserValue("Введите число: ");
int m = 1;

Console.WriteLine(IntervalofNumbs(n, m));
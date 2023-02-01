Console.Clear();

int getUserValue(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int AllSumNumbs(int m, int n)
{
    if (m == n)
        return n;
    return n + AllSumNumbs(m, n - 1);
}

int m = getUserValue("Введите M:");
int n = getUserValue("Введите N:");

Console.WriteLine($"Сумма элементов от {m} до {n} = {AllSumNumbs(m, n)}");
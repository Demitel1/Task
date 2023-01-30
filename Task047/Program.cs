Console.Clear();

int getUserValue(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void DoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 99+1) / 10.0;
        }
    }
}

void showdDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = getUserValue("Введите количество строк: ");
int colums = getUserValue("Введите количество столбцов: ");
double[,] numbers = new double[rows, colums];

DoubleArray(numbers);
showdDoubleArray(numbers);
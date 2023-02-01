Console.Clear();

int getUserValue(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

void ArithmeticMean(int[,] numbers, int rows)
{
    double avarage = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            avarage = (avarage + numbers[i, j]);
        }
        avarage = avarage / rows;
        Console.Write(avarage + "; "); 
    }
    return; 
}

void DoubleArrays(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void showdDoubleArray(int[,] array)
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
int[,] numbers = new int[rows, colums];

DoubleArrays(numbers);
showdDoubleArray(numbers);
ArithmeticMean(numbers,rows);

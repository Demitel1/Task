Console.Clear();

int rows = getUserValue("Введите количество строк: ");
int colums = getUserValue("Введите количество столбцов: ");
int [,] numbers = new int [10,10];

int getUserValue(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 10);
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

void PrintResult(int[,] numbers)
{
    if (rows > numbers.GetLength(0) || colums > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {rows} строки и {colums} столбца равно {numbers[rows-1,colums-1]}");
    }
}

FillArrayRandomNumbers(numbers);
showdDoubleArray(numbers);
PrintResult(numbers);
int getUserValue(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}

void RandomNumbs(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10); 
    }
    }
}

void showdArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = getUserValue("Введите размер матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
RandomNumbs(matrixA);
RandomNumbs(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
showdArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
showdArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
showdArray(matrixC);
Console.Clear();

int size = getUserValue("Введите размер массива: ");
int[,] nums = new int[size, size];

int getUserValue(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int ArrayNums(int[,] nums)
{
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= size * size)
    {
        nums[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
    }
    return num;
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

ArrayNums(nums);
showdDoubleArray(nums);
Console.Clear();

int getUserValue(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

void ConvertNumbers(int[,] nums)
{
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < nums.GetLength(1) - 1; z++)
        {
            if (nums[i, z] < nums[i, z + 1]) 
            {
                int temp = 0;
                temp = nums[i, z];
                nums[i, z] = nums[i, z + 1];
                nums[i, z + 1] = temp;
            }
        }
    }
}
}
void RandomNumbs(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

int size = getUserValue("Введите размер массива: ");
int[,] nums = new int[size, size];

Console.WriteLine();
Console.WriteLine("Массив до изменения порядка чисел");
RandomNumbs(nums);
showdDoubleArray(nums);
Console.WriteLine();
Console.WriteLine("Массив после изменения порядка чисел");
ConvertNumbers(nums);
showdDoubleArray(nums);
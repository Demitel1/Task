Console.Clear();

int[] getUserValue(string message)
{
    Console.Write(message);
    int[] result = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return result;
}

int[] number = getUserValue("Введите числа через пробел: ");

int[] getResultNumber(int number)
{
    int[] count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number > 0)
        {
            count++;
        }
        
    }
    return count;  
}

int[] count = getResultNumber(number);

Console.WriteLine($"Кол-во элементов > 0: {count}");
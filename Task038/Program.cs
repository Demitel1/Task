Console.Clear();

int[] getArrayRandom(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 9+1);   
    }
    return array;
}

int getResult(int[] array)
{
    int min = array.Min();
    int max = array.Max();
    int result = max - min;
    return result;
}

void showArray(int[] array)
{
    Console.Write($"[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i != array.Length - 1)
        {Console.Write($"{array[i]},");}
        else
        {Console.Write($"{array[i]}]");}
    }
}

int[] array = getArrayRandom(4);
int sum = getResult(array);
showArray(array);
Console.WriteLine($" -> разница между max и min = {sum}");
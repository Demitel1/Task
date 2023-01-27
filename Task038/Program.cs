Console.Clear();

int[] getArrayRandom(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-5, 4+1);   
    }
    return array;
}

int getMinNumber(int[] array)
{
    int min = 0; int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min)
        {
            min = array[i];
        }
        else
        {
            max = array[i];
        }
    }
    return min;
}

int getMaxNumber(int[] array)
{
    int min = 0; int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min)
        {
            max = array[i];
        }
        else
        {
            min = array[i];
        }
    }
    return max;
}

int getResult(int max; int min)
{
    int result = getMaxNumber - getMinNumber;;
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

int result = getResult(max;min);
int min = getMinNumber(array);
int max = getMaxNumber(array);
int[] array = getArrayRandom(5);
int sum = getSum(array);
showArray(array);
Console.WriteLine($" cумма нечетных чисел = {result}");

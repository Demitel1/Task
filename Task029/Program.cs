int[] getArrayRandom(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 50+1);   
    }
    return arr;
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

int[] array = getArrayRandom(8);
showArray(array);
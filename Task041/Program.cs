Console.Clear();

string getUserValue(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

int getResultTemp(string numb)
{
    int temp = 0;
    int count = 0;
    for (int i = 0; i < numb.Length; i++)
    {
        if (numb[i] != ',')
        {
            temp += numb[i];
        }
        else if(Convert.ToInt32(temp) > 0) 
        {
            count++;
        }
    }
    if (Convert.ToInt32(temp) > 0) {count++;}
    return count;
}

string numb = getUserValue("Введите числа через запятую: ");

Console.WriteLine($"Число чисел > 0 = {getResultTemp(numb)}");
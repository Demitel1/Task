Console.Clear();

int getUserValue(string messege)
{
    Console.Write(messege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}



int getNumberOfDigit(int number)
{
    int i = 0;
    while(number > 0)
    {
        i = i + number % 10;
        number = number / 10;
    }
    return i;
}

int number = getUserValue("Введите число: ");
int number2 = getNumberOfDigit(number);
Console.Write($"Сумма чисел {number} = {number2}");

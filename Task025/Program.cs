Console.Clear();

int getUserValue(string messege)
{
    Console.Write(messege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int number1 = getUserValue("Введите число: ");
int number2 = getUserValue("Введите степень числа: ");

int degree = 0;
int sum = 1;

while(degree < number2)
{
    sum = sum * number1;
    degree++;
}

Console.WriteLine($"{sum}");
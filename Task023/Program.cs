Console.Clear();

int getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int number1 = getUserValue("Введите число: ");
int number2 = 1; 

while (number2 <= number1)
{
    if(number2 < number1)
    {Console.Write(Math.Pow(number2, 3) +  ", ");
    number2++;}
    else if(number2 == number1)
    {Console.Write(Math.Pow(number2, 3) + ".");
    number2++;}
}
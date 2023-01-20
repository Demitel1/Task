Console.Clear();

int getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int number1 = getUserValue("Введите первое число: ");
int number2 = getUserValue("Введите второе число: ");

if(number1 > 0 && number2 > 0)
{
    Console.Write(Math.Pow(number1, number2));
}
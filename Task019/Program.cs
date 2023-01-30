Console.Clear();

Console.Write("Введите проверяемое число: ");
int number = int.Parse(Console.ReadLine()!);

int secondnumber1(int number)
{
    int result = number / 10000;
    return result;
}
int firstnumber1 = secondnumber1(number);

int secondnumber2(int number)
{
    int number1 = (number % 10) * 100;
    int number2 = ((number % 100) / 10) * 10;
    int number3 = (number % 1000) / 100; 
    int result = number1 + number2 + number3;
    return result;
}
int firstnumber2 = secondnumber2(number);

if (firstnumber1 == firstnumber2)
{
    Console.Write("Число является палиндромом.");
}
else
{
    Console.Write("Число не является палиндромом.");
}
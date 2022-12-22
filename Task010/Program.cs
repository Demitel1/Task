Console.Clear();

Console.Write("Введите трехзначное число: ");
int firstnumber = int.Parse(Console.ReadLine()!);
int secondnumber = (firstnumber % 100) / 10;

if (firstnumber >= 100 && firstnumber <= 999)
{
    Console.WriteLine($"Из числа {firstnumber} второе число {secondnumber}");
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}

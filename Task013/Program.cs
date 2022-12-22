Console.Clear();

Console.Write("Введите трехзначное число: ");
int firstnumber = int.Parse(Console.ReadLine()!);
int secondnumber = (firstnumber / 10) % 10;

if (firstnumber >= 100)
{
    Console.WriteLine($"Из числа {firstnumber} третье число {secondnumber}");
}
else
{
    Console.WriteLine("В введенном числе нет третей цифры.");
}

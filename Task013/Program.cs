Console.Clear();

Console.Write("Введите трехзначное число: ");
int firstnumber = int.Parse(Console.ReadLine()!);
int secondnumber = firstnumber % 10;

if (firstnumber >= 100 && firstnumber <= 999)
{
    Console.WriteLine($"Из числа {firstnumber} третье число {secondnumber}");
}
else if (firstnumber >= 1000 && firstnumber <=9999)
{
    secondnumber = (firstnumber / 10)% 10;
    Console.WriteLine($"Из числа {firstnumber} третье число {secondnumber}");
}
else if (firstnumber >= 10000 && firstnumber <=99999)
{
    secondnumber = (firstnumber / 100)% 10;
    Console.WriteLine($"Из числа {firstnumber} третье число {secondnumber}");
}
else
{
    Console.WriteLine("В введенном числе нет третей цифры.");
}

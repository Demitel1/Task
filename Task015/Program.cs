Console.Clear();

Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 6 && number <= 7)
{
    Console.WriteLine("Выходной день!");
}
else if (number >= 1 && number <= 5)
{
    Console.WriteLine("Рабочий день!");
}
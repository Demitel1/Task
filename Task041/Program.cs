Console.Clear();

int[] getUserValue(string messege)
{
    Console.Write(messege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
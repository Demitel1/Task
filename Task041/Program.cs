Console.Clear();

string inputStr = ReadString("Введите числа через зяпятую: ");
int count = 0;
string tmpStr = string.Empty;

for (int i = 0; i < inputStr.Length; i++)
{
    if (inputStr[i] != ',') tmpStr += inputStr[i];
    else
    {
        if (Convert.ToInt32(tmpStr) > 0) count++;
        tmpStr = string.Empty;
    }
}
if (Convert.ToInt32(tmpStr) > 0) 
{
    count++;
}

Console.WriteLine($"Введено {count} чисел больше 0.");

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
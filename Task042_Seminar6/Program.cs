/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/


string ConvertToBool(int num)
{
    string result = "";
    while (num > 0)
    {
        result = (num%2) + result;
        num = num / 2;
    }
    return result;

}

Console.WriteLine("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
string boolNumber = ConvertToBool(decimalNumber);
Console.WriteLine(boolNumber);
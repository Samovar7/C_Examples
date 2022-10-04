/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

string Fibo(int num)
{
    int f1 = 0;
    int f2 = 1;
    int f3 = 0;
    string result = "0 1";
    for (int i = 3; i <= num; i++)
    {
        f3 = f1 + f2;
        result = result + " " + f3;
        f1 = f2;
        f2 = f3;
    }
    return result;

}

Console.WriteLine("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ряд Фибоначчи для первых {decimalNumber} будет: {Fibo(decimalNumber)} ");
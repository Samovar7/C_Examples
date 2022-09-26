/*

Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36

void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int getSumOfRange(int startPoint, int endPoint)
{
    int result = 0;
    if (startPoint > endPoint)
    {
        printInConsoleWithColor($"Верхняя граница отрицательна {endPoint}",ConsoleColor.DarkYellow);
        int buff = startPoint;
        startPoint = endPoint;
        endPoint = buff;
    }
    for (int i = startPoint; i <= endPoint; i++)
    {
        result += i;
    }
    return result;
}

printInConsoleWithColor("Введите верхнюю границу для суммы ряда",ConsoleColor.DarkMagenta);
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfRage = getSumOfRange(1, userNumber);
Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {sumOfRage}");
Дмитрий Соломонов Кому Все
22:33:56
ДС
Program.cs
1.1 KB
/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int getSumOfRange(int startPoint, int endPoint)
{
    int result = 0;
    if (startPoint > endPoint)
    {
        printInConsoleWithColor($"Верхняя граница отрицательна {endPoint}",ConsoleColor.DarkYellow);
        int buff = startPoint;
        startPoint = endPoint;
        endPoint = buff;
    }
    for (int i = startPoint; i <= endPoint; i++)
    {
        result += i;
    }
    return result;
}

printInConsoleWithColor("Введите верхнюю границу для суммы ряда",ConsoleColor.DarkMagenta);
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfRage = getSumOfRange(1, userNumber);
Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {sumOfRage}");
*/

int getSum Of Range(int startPoint, int endPoint)
{
    int result = 0;
    endPoint = Math.Abs

}


int getNumberFromUser() // Функция получения числа от пользователя.
{
    int result = 0;
    while(result == 0 || result < 1)
    {
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 || result < 1  )
        {
            Console.WriteLine($"Введите целое число больше 0 вы ввели {userLine}");
        }
        
    }
    return result;
}

Console.WriteLine("Введите верхню границу для суммы радя");
int userNumber = Convert.ToInt32(Console.ReadLine());



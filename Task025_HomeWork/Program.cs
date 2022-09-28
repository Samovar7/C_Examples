/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int getNumberFromUser() //Функция получения нужного числа от пользователя.
{
    int result = 0;
    while(result == 0 || result < 2)
    {
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 || result < 2  )
        {
            Console.WriteLine($"Введите целое число больше 1 вы ввели {userLine}");
        }
        
    }
    return result;
}

int numPowerNum (int A, int B) // Функция возведения числа А в степень В
{
    int result = A;
    for (int i = 2; i <= B; i++)
    {
      result = result * A;  
    }
    return result;
}

Console.Write("Введите число А: ");
int numberA = getNumberFromUser();
//Console.WriteLine();
Console.Write("Введите число B: ");
int numberB = getNumberFromUser();
int resultPow = numPowerNum(numberA, numberB);
Console.WriteLine();
Console.WriteLine($"Значение возведения числа {numberA} в степень {numberB} равно: {resultPow}");

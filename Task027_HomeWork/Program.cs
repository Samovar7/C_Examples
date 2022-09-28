/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int getNumberFromUser() //Функция получения нужного числа от пользователя.
{
    int result = 0;
    while(result == 0 )
    {
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 )
        {
            Console.WriteLine($"Введите целое число больше или меньше 0 вы ввели {userLine}");
        }
        if (result < 0)
        {
            result = Convert.ToInt32 (Math.Abs(result));
        }
    }
    return result;
}

int sumNumbers (int userNumber) // Функция подсчета суммы всех цифр из которого состоит число.
{
    int sum = 0;
    while (userNumber > 0)
    {
        sum = sum + userNumber%10;
        userNumber = userNumber / 10;
    }
    return sum;
}


Console.Write("Введите число больше или меньше 0: ");
int numberUser = getNumberFromUser();
Console.WriteLine($"Сумма всех цифр числа {numberUser} равна: {sumNumbers(numberUser)}");

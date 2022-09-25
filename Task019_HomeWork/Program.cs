/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int get_number_size ( int div) // Определяем количество цифр в числе
{
    int number_size = 0;
    while (div > 0)
        {
        div = div / 10;
        number_size++;
        }
    Console.WriteLine($"В веденном числе {number_size} цифр.");
    return number_size;
}

int getNumberFromUser() // Получаем число от пользователя
{
    int result = 0;
    while(result == 0 || result < 10)
    {
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result < 10)
        {
            Console.WriteLine($"Введите любое цело число больше 9, вы ввели {userLine}");
        }
        
    }
    return result;
}

Console.Write("Введите любое цело число больше 9: ");
int userNumber = getNumberFromUser();
int size = get_number_size(userNumber);

int length = size / 2;
bool pol = true;
for (int i = 0; i < length; i++)
{
   if ((userNumber / Convert.ToInt32(Math.Pow(10, i)))%10 != (userNumber / Convert.ToInt32(Math.Pow(10, (size - 1 - i))))%10)
   {
        pol = false;
        break;
   } 
}
if (pol)
{
    Console.WriteLine($"Число {userNumber} - Палиндром!");
}
else
{
    Console.WriteLine($"Число {userNumber} не является палиндромом.");
}

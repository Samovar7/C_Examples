/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
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

Console.Write("Введите любое целое число: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите какую цифру по порядку в вашем числе, нужно вывести на экран: ");
int seq_number = Convert.ToInt32(Console.ReadLine());
int size_number = get_number_size(user_number);

if (size_number < seq_number)
{
    Console.WriteLine($"В вашем числе нет {seq_number} цифры.");
}
else
{
    //int seq = (user_number / 10^(size_number - seq_number))%10; возведение в степень таким образом работает как-то не правильно
    int i = Convert.ToInt32(Math.Pow(10, (size_number - seq_number))); // Вычисляем на 10 в какой степени будем делить на цело наше число
    int seq = (user_number / i)%10;
    Console.WriteLine($"{seq_number} цифра в вашем числе {user_number} равна {seq}");
}

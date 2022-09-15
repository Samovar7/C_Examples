Console.WriteLine("Введите число от 1 до 7 включительно");
int day_number = new Random().Next(1,8); //будут генерится числа от 1 до 7 включительно
Console.WriteLine($"Вы ввели {day_number}");

if (day_number == 1)
{
    Console.WriteLine($"{day_number} - Понедельник");
}
if (day_number == 2)
{
    Console.WriteLine($"{day_number} - Вторник");
}
if (day_number == 3)
{
    Console.WriteLine($"{day_number} - Среда");
}
if (day_number == 4)
{
    Console.WriteLine($"{day_number} - Четверг");
}
if (day_number == 5)
{
    Console.WriteLine($"{day_number} - Пятница");
}
if (day_number == 6)
{
    Console.WriteLine($"{day_number} - Суббота");
}
if (day_number == 7)
{
    Console.WriteLine($"{day_number} - Воскресенье");
}
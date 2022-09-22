/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число:");
int user_number = Convert.ToInt32(Console.ReadLine());
if (user_number < 100 || user_number > 999)
{
    Console.WriteLine ("Вы ввели не трехзначное число, попробуйте еще раз.");
}
else 
{ int second_num = (user_number / 10)%10;
Console.WriteLine($"Вторая цифра в числе: {second_num}");
}
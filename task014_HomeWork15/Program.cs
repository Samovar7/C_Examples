/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите число от 1 до 7:");
int day_number = Convert.ToInt32(Console.ReadLine());
if (day_number < 1 || day_number > 7)
{
    Console.WriteLine ("Вы ввели число не из диапазона 1-7, попробуйте еще раз.");
}
else if (day_number > 5)
{
Console.WriteLine ("Это выходной день");
}
else
{Console.WriteLine ("Это будний день");}

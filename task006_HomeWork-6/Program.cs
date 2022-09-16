/*
Задача 6: Напишите программу, которая на вход принимает число 
и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/
Console.WriteLine("Введите  число:");
//int user_number1 = new Random().Next(1,100);
int user_number1 = Convert.ToInt32(Console.ReadLine());

if (user_number1%2 == 0)
{
    Console.WriteLine($"Вы ввели число {user_number1}, это число является Четным");
}
else
{
Console.WriteLine($"Вы ввели число {user_number1}, это число нечетное");
}
/*
Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
*/
Console.WriteLine("Введите первое число:");
int user_number1 = new Random().Next(1,100);
//int user_number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int user_number2 = new Random().Next(1,100);
//int user_number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int user_number3 = new Random().Next(1,100);
//int user_number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели следующие числа {user_number1}, {user_number2}, {user_number3}");
int max = user_number1;
if (max > user_number2)
{
    if (max > user_number3)
    {} 
    else 
    {max = user_number3;}
    
}
else
{
    if (user_number2 > user_number3)
    {
        max = user_number2;
    }
    else {max = user_number3;}
}
 Console.WriteLine($"Максимальное число: {max}");
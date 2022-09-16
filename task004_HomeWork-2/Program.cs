/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
*/
Console.WriteLine("Введите первое число:");
int user_number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int user_number2 = Convert.ToInt32(Console.ReadLine());
if (user_number1 == user_number2)
{
    Console.WriteLine($"Эти числа равны");
}
else
{
    if (user_number1 > user_number2)
    {
        Console.WriteLine($"Число {user_number1} - большее, число {user_number2} - меньшее");
    }
    else Console.WriteLine($"Число {user_number2} - большее, число {user_number1} - меньшее");
}
Console.WriteLine("Введите первое число:");
int user_number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int user_number2 = Convert.ToInt32(Console.ReadLine());
if (user_number1 == user_number2 * user_number2)
{
Console.WriteLine($"Число {user_number1} является квадратом числа {user_number2}");
}
else
{
Console.WriteLine($"Число {user_number1} не является квадратом числа {user_number2}");
}
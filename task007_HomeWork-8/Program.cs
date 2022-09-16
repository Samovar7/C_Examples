/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/
Console.WriteLine("Введите  число:");
//int user_number = new Random().Next(1,100);
int user_number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (user_number < count)
{
   while (count >= user_number)
{
       if (count%2 == 0)
    {
        Console.Write($"{count}: ");
    }
     count--;
} 
}
else
{
    while (count <= user_number)
    {
       if (count%2 == 0)
        {
        Console.Write($"{count}: ");
        }
        count++;
    }
}
Console.WriteLine();

/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


int getNumberFromUser()
{
    int result = 0;
    while(result == 0 || result < 1)
    {
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 || result < 1  )
        {
            Console.WriteLine($"Введите целое число больше 0 вы ввели {userLine}");
        }
        
    }
    return result;
}
Console.Write("Input int number: ");
int count = getNumberFromUser();
for (int i = 1; i <= count; i++)
{
    int kub = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($"{kub}, ");
}
Console.WriteLine();

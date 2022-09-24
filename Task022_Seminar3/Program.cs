/*
 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
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
    int kvadrat = i * i;
    Console.Write($"{kvadrat}, ");
}
Console.WriteLine();

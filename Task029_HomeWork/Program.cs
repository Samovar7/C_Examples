/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

int getNumberFromUser() //Функция получения нужного числа от пользователя.
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

void FillArray(int[] collection) // Функция заполнения массива в случайными числами от 1 до 99
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}
void PrintArray(int[] col)
{
    int position = 0;
    if (col.Length > 1)
    {
    int count = col.Length - 1;
        Console.Write($"[{col[position]}");
    position++;
    while (position < count)
    {
        Console.Write($", {col[position]}");
        position++;
    }
    Console.Write($", {col[count]}]");
    }
    else
    {
      Console.Write($"[{col[position]}]");  
    }
}

Console.Write("Введите число, задающее размер массива, больше 0: ");
int arrayLength = getNumberFromUser();
int[] array = new int[arrayLength];
FillArray(array);
PrintArray(array);
Console.WriteLine();


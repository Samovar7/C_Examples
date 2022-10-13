/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerateArray(int height, int weight, int deviation)
{
    int[,] generatedArray = new int[height,weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i,j] = new Random().Next(-deviation, deviation+1);
        }
    }
    return generatedArray;
}

void NumberOfStringMinSum (int[,] incomingArray)
{
    int sum = 0, minSum = new int(), indexOfString = 0;
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            sum += incomingArray[i,j];
        }
        if (minSum > sum)
        {
            minSum = sum; indexOfString = i;
        }
    }
    System.Console.WriteLine($"{indexOfString} строка с наименьшей суммой элементов");
    return;
}


void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void ShowArray(int[,] inputArray)
{
    PrintColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        PrintColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        PrintColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j].ToString()}\t");
        }
        Console.WriteLine();
    }
}

int[,] userArray = GenerateArray (5, 4, 10);
ShowArray(userArray);
NumberOfStringMinSum(userArray);





/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] SortArray(int[,] incomingArray)
{
    int[] stringForSort = new int[incomingArray.GetLength(1)];
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            stringForSort[j] = incomingArray[i,j];
        }
        stringForSort = SortStringOfArray(stringForSort, 0);
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            incomingArray[i,j] = stringForSort[j];
        }
    }
    return incomingArray;
}

int[] SortStringOfArray(int[] incomingArray, int start) // Функция рекурсивно сортирующая одномерный массив по убывающей.
{
    if (start == incomingArray.Length) return incomingArray;
    int temp = incomingArray[start];
    int max = incomingArray[start];
    int index = start;
    for (int i = start; i < incomingArray.Length; i++)
    {
        if (max < incomingArray[i] )
        {
            index = i;
            max = incomingArray[i];
        }
    }
    incomingArray[start] = max;
    incomingArray[index] = temp;
    SortStringOfArray (incomingArray, start+1);
    return incomingArray;
} 

/*
int[] SortString(int[] incomingArray) // Функция сортирующая одномерный массив по убыванию прямым перебором в двойном цикле.
{
    
    
    for (int i = 0; i < incomingArray.Length; i++)
    {
        int temp = incomingArray[i];
        int max = incomingArray[i];
        int index = i;
    
    for (int j = i; j < incomingArray.Length; j++)
    {
        if (max < incomingArray[j] )
        {
            index = j;
            max = incomingArray[j];
        }
    }
    incomingArray[i] = max;
    incomingArray[index] = temp;
    }

    return incomingArray;
} 
*/
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

int[,] userArray = GenerateArray (10, 10, 100);
ShowArray(userArray);
Console.WriteLine();
int[,] sortArr = SortArray(userArray);
ShowArray(sortArr);


/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void showArray(int[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j].ToString()}\t");
        }
        Console.WriteLine();
    }
}
int[,] SwopRows(int[,] inputArray, int RowIndex1, int RowIndex2)
{
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        int buffer = inputArray[RowIndex1,i];
        inputArray[RowIndex1,i] =  inputArray[RowIndex2,i];
        inputArray[RowIndex2,i] = buffer;
    }
    return inputArray;
}
int[,] generatedArray = GenerateArray(5,10,100);
showArray(generatedArray);
int[,] swoppedArray = SwopRows(generatedArray,0,generatedArray.GetLength(0) - 1);
showArray(swoppedArray);
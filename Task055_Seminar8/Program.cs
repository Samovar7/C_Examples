/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
int[,] SwopRows(int[,] inputArray, int RowIndex1, int ColumnIndex2)
{
    if (inputArray.GetLength(0) != inputArray.GetLength(1))
    {
        Console.WriteLine("Заменить строку на столбец невозможно!");
        return inputArray;
    }
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = i; j < inputArray.GetLength(1); j++)
        {
        int buffer = inputArray[i,j];
        inputArray[i,j] =  inputArray[j,i];
        inputArray[j,i] = buffer;
        }
    }
    return inputArray;
}

int[,] generatedArray = GenerateArray(5,5,100);
showArray(generatedArray);
int[,] swoppedArray = SwopRows(generatedArray,2,4);
showArray(swoppedArray);
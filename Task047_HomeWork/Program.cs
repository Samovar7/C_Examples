/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] Generate2DArray(int height, int width, int rndStart, int rndEnd)
{
    double[,] twoDArray = new double[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Random rnd = new Random();
            double doubleRnd = rnd.NextDouble();
            int intRnd = new Random().Next(rndStart, rndEnd+1);
            double sumRnd = doubleRnd + intRnd;
            twoDArray[i,j] = Math.Round(sumRnd, 1);
        }
    }
    return twoDArray;
}

void PrintColorData (string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void Print2DArray(double[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        PrintColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        PrintColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] generatedArray = Generate2DArray(5, 5, -10, 10);
Print2DArray(generatedArray);

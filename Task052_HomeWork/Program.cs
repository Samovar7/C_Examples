/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] Generate2DArray(int height, int width, int rndStart, int rndEnd) // Функция генерации двумерного массива случайными целыми числами.
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(rndStart, rndEnd+1);
        }
    }
    return twoDArray;
}

void ArithmeticMeanOfColumn(int[,] incomingArray) // Функция определения среднеарифметического значения в каждом столбце массива.
{
    double[] arithmeticMeanArray = new double[incomingArray.GetLength(1)];
    
    for (int j = 0; j < incomingArray.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < incomingArray.GetLength(0); i++)
        {
            sum = sum + incomingArray[i,j];
        }
        arithmeticMeanArray[j] = Math.Round((Convert.ToDouble (sum) / Convert.ToDouble(incomingArray.GetLength(0))), 2);
    }
    Console.Write( "Ср.ар." );
    for (int i = 0; i < arithmeticMeanArray.Length ; i++)
    {
        Console.Write( "\t" + arithmeticMeanArray[i] );
    }
    Console.WriteLine();
}


void PrintColorData (string data)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(data);
    Console.ResetColor();
}

void Print2DArray(int[,] arrayToPrint) // Функция печати массива.
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

int[,] generatedArray = Generate2DArray(6, 5, -10, 10);
Print2DArray(generatedArray);
ArithmeticMeanOfColumn(generatedArray);



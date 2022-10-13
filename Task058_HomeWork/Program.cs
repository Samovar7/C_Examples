/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MassiveMultiplikation(int[,] ArrayA, int[,] ArrayB) // Функция умножения двумерных массивов
{
    int[,] ArrayC = new int [ArrayA.GetLength(0), ArrayB.GetLength(1)];
    if (ArrayA.GetLength(1) != ArrayB.GetLength(0))
    {
        System.Console.WriteLine("Эти массивы нельзя умножить, не совпадение размерностей.");
        ArrayC = new int[1,1];
        return ArrayC;
    }
    
    for (int j = 0; j < ArrayB.GetLength(1); j++)
    {
        for (int i = 0; i < ArrayA.GetLength(0); i++)
        {
            int sum = 0;
            int multiplication = 1;
            for (int k = 0; k < ArrayA.GetLength(1); k++)
            {
               multiplication = ArrayA[i,k] * ArrayB[k,j] ;
               sum += multiplication;
            }
            ArrayC[i,j] = sum;
        }
    }
    return ArrayC;
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

int[,] ArrayA = GenerateArray(3, 3, 10);
int[,] ArrayB = GenerateArray(4, 4, 10);
ShowArray(ArrayA);
Console.WriteLine();
ShowArray(ArrayB);
Console.WriteLine("Произведение массива А на массив В = массив С:");
ShowArray(MassiveMultiplikation(ArrayA, ArrayB));
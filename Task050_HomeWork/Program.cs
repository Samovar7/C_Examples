/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
*/
int GetNumberFromUser() //Функция получения нужного числа от пользователя.
{
    int result = 0;
    string userLine = String.Empty;
    while((result == 0 && userLine != "0") || result < 0)
    {
        userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if ((result == 0 && userLine != "0") || result < 0  )
        {
            Console.WriteLine($"Введите целое положительное число включая 0, вы ввели {userLine}");
        }
        
    }
    return result;
}

int[,] Generate2DArray(int height, int width, int rndStart, int rndEnd) // Функция генерации двумерного массива случайными целыми числами
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

void ValueOfUserNumber(int[,] incomingArray, int userNumber) //Функция определения значения элемента массива в позиции заданной пользователем.
{
    if (userNumber > incomingArray.GetLength(1) * incomingArray.GetLength(0)-1 )
    {
        Console.WriteLine($"В массиве не существует {userNumber} позиции, задайте значение меньше.");
    }
    else
    {
        int i = userNumber/incomingArray.GetLength(1);
        int j = userNumber%incomingArray.GetLength(1);
        int result = incomingArray[i,j];
    Console.WriteLine($"В массиве на {userNumber} позиции значение элемента = {result}");
    }
    

}


void PrintColorData (string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void Print2DArray(int[,] arrayToPrint) //Функция печати массива
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

int[,] generatedArray = Generate2DArray(4, 5, -10, 10);
Print2DArray(generatedArray);
Console.Write("Введите позицию элемента в массиве, значение которого хотите узнать:");
int userNumber = GetNumberFromUser();
ValueOfUserNumber(generatedArray, userNumber);




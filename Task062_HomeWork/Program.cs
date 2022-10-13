/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int[,] SpiralFillArray(int[,] userArray, List<int> listNumber, int count, int strStart, int strEnd, int clmStart, int clmEnd) // Функция рекурсивного спирального заполнения
{
    int capasity = userArray.GetLength(0) * userArray.GetLength(1);
  
    for (int j = clmStart; j <= clmEnd; j++)
    {
        userArray[strStart,j] = listNumber[count];
        count++;
        if (count > capasity-1) return userArray;
    }
    strStart++;
    
    for (int i = strStart; i <= strEnd; i++)
    {
        userArray[i,clmEnd] = listNumber[count];
        count++;
        if (count > capasity-1) return userArray;
    }
    clmEnd--;
    for (int j = clmEnd; j >= clmStart; j--)
    {
        userArray[strEnd,j] = listNumber[count];
        count++;
        if (count > capasity-1) return userArray;
    }
    strEnd--;
    for (int i = strEnd; i >= strStart; i--)
    {
        userArray[i,clmStart] = listNumber[count];
        count++;
        if (count > capasity-1) return userArray;
    }
    clmStart++;
    SpiralFillArray(userArray, listNumber, count, strStart, strEnd, clmStart, clmEnd);
    return userArray;
}
/*
int[,] SpiralFillArray(int[,] userArray, List<int> listNumber, int count, int strStart, int strEnd, int clmStart, int clmEnd) // Функция прямого перебора спирального заполнения массива
{
    int capasity = userArray.GetLength(0) * userArray.GetLength(1);
    while (count <= capasity-1)
    {
            
        for (int j = clmStart; j <= clmEnd; j++)
        {
            userArray[strStart,j] = listNumber[count];
            count++;
            if (count > capasity-1) return userArray;
        }
        strStart++;
        
        for (int i = strStart; i <= strEnd; i++)
        {
            userArray[i,clmEnd] = listNumber[count];
            count++;
            if (count > capasity-1) return userArray;
        }
        clmEnd--;
        for (int j = clmEnd; j >= clmStart; j--)
        {
            userArray[strEnd,j] = listNumber[count];
            count++;
            if (count > capasity-1) return userArray;
        }
        strEnd--;
        for (int i = strEnd; i >= strStart; i--)
        {
            userArray[i,clmStart] = listNumber[count];
            count++;
            if (count > capasity-1) return userArray;
        }
        clmStart++;
    }
    
    return userArray;
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

int weight = 5;
int height = 5;
int[,] userArray = new int[weight,height];
int count = 0;
int strStart = 0, clmStart = 0, strEnd = userArray.GetLength(0)-1, clmEnd = userArray.GetLength(1)-1;
int arrayCapacity = userArray.GetLength(0) * userArray.GetLength(1);
List<int> numberForArray = new List<int>(arrayCapacity);
for (int i = 0; i < arrayCapacity; i++)
{
    numberForArray.Add(i+1);
}
SpiralFillArray(userArray, numberForArray, count, strStart, strEnd, clmStart, clmEnd);
ShowArray(userArray);
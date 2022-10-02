/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/


int[] getRandomArray (int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int getSumOfPositiveNumbersInArray(int[] incomingArray )
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > 0)
        {
            result += incomingArray[i];
        }
    }
    return result;
}

int getSumOfNegativeNumbersInArray(int[] incomingArray )
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] < 0)
        {
            result += incomingArray[i];
        }
    }
    return result;
}

int getSumOfPositiveOrNegativeNumbersInArray(int[] incomingArray, int deviation )
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] * deviation > 0)
        {
            result += incomingArray[i];
        }
    }
    return result;
}



int[] currentArray = getRandomArray(12,-9,9);
printArray(currentArray);
int sumOfPositive = getSumOfPositiveNumbersInArray(currentArray);
int sumOfNegative = getSumOfNegativeNumbersInArray(currentArray);

Console.WriteLine($"Сумма положительных чисел в массиве {sumOfPositive}, сумма отрицательных чисел {sumOfNegative}");

sumOfPositive = getSumOfPositiveOrNegativeNumbersInArray(currentArray,1);
sumOfNegative = getSumOfPositiveOrNegativeNumbersInArray(currentArray,-1);

Console.WriteLine($"Сумма положительных чисел в массиве {sumOfPositive}, сумма отрицательных чисел {sumOfNegative}");

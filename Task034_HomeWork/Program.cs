/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] generateArray(int length, int start, int end) //Функция генерации массива
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void printArray(int[] incomingArray) //Функция печати массива
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

int CountEvenNumber (int[] inputArray) //Функция нахождения количества четных элементов массива
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] currentArray = generateArray(20, 100, 1000);
printArray(currentArray);
Console.WriteLine($"В заданном массиве количество четных чисел = {CountEvenNumber(currentArray)}");
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] generateArray(int length, int start, int end)
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

int SumNonEvenNumber (int[] inputArray) //Функция нахождения суммы элементов массива на нечетных позициях
{
    int sum = 0;
    for (int i = 1; i < inputArray.Length; i = i +2)
    {
       sum = sum + inputArray[i];
       
    }
    return sum;
}


int[] currentArray = generateArray(11, -10, 11);
printArray(currentArray);
Console.WriteLine($"Сумма не четных элементов массива = {SumNonEvenNumber(currentArray)}");
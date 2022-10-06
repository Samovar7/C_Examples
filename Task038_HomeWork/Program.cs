/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] generateArray(int length, int start, int end) //Функция генерации массива вещественных чисел
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        Random rnd = new Random();
        double doubleRnd = rnd.NextDouble();
        int intRnd = new Random().Next(start, end + 1);
        array[i] = intRnd + doubleRnd;
        //array[i] = rnd.Next(start, end);
    }
    return array;
}

double FindDiffMinMax(double[] incomingArray) //Функция поиска разности между максимальным и минимальным значением массива
{
    double min = incomingArray[0];
    double max = incomingArray[0];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i] < min) {min = incomingArray[i];}
        else if(incomingArray[i] > max) {max = incomingArray[i];}
    }
    double difMinMax = max - min;
    return difMinMax;

}


void printArray(double[] incomingArray) //Функция печати массива
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double[] currentArray = generateArray(10, -10, 10);
printArray(currentArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {FindDiffMinMax(currentArray)}");
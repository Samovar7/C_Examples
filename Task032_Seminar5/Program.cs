/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] getRandomArray (int length, int startPoint, int endPoint) // получение рандомного массива заданной длины и диапазона значений
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

int[] NegativeArray (int[] incomingArray)
{
    for (int i = 0; i < incomingArray.Length; i++)
    {
        incomingArray[i] *= -1;
    }
    return incomingArray;
}


int[] currentArray = getRandomArray(20,-20,20);
printArray(currentArray);
int[] negativeArray = NegativeArray(currentArray);
printArray(negativeArray);

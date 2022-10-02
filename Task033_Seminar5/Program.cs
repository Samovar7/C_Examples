/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

void findNumber (int[] incomingArray, int numberFind)
{
    bool find = false;
    for (int i = 0; i < incomingArray.Length; i++)
    {
     if (incomingArray[i] == numberFind)   
     {
       find = true;
       break;
     }
    }
    if (find)
    {
        Console.WriteLine($"Число {numberFind} найдено в массиве.");
    }
    else
    {
        Console.WriteLine($"Число {numberFind} отсутствует в массиве.");
    }   
}

int[] currentArray = getRandomArray(20,-20,20);
Console.Write("Введите целое число для поиска в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
printArray(currentArray);
findNumber(currentArray, userNumber);
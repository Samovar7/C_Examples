/*
Напишите программу, котрая находит подмножество данного множества чисел такое, что сумма его элементов равна заданному числу
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


/*int[] optimizearr (int[] incomingArray, int N) //Функция оптимизации массива, отсечение всех значений больше числа N (не работает при минусовых значениях в массиве)
{
    List<int> optimizedList = new List<int>();
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] <= N)
        {
            optimizedList.Add(incomingArray[i]);
        }
    }
    int[] optimizearray = optimizedList.ToArray();
    return optimizearray;
}
*/

void checkArray (int[] incomingArray, int N, int index, int position, int countNum, int Sum, int length)
{
    List<int> subSet = new List<int>();
    for (int i = index; i < length; i++)
    {
        if (position == countNum)
        {
            LastChekAndPrint(incomingArray, index, N, Sum, position, subSet, length);
            break;
        }
        Sum = Sum + incomingArray[i];
        if (Sum < N && position != countNum)
        {
            subSet.Add(incomingArray[i]);
            index = i + 1;
            position++;
            checkArray(incomingArray,N, index, position, countNum, Sum, length);
            position--;
            Sum = Sum - incomingArray[i];
        }
        else Sum = Sum - incomingArray[i];

    }
}

void PrintSubset(List<int> subSet) //печать списка
{
    Console.WriteLine(string.Join(", ", subSet));
}


void LastChekAndPrint (int[] incomingArray, int index, int N, int Sum, int position, List<int> subSet, int length) // Завершающая функция последнего прохода по массиву и печати множества
{
    for (int i = index; i < length; i++)
    {
        Sum = Sum + incomingArray[i];
        if (Sum == N)
        {
            subSet.Add(incomingArray[i]);
            PrintSubset(subSet);
            subSet.RemoveAt(position-1);
            Sum = Sum - incomingArray[i];
        }
        else Sum = Sum - incomingArray[i];
    }

}

int[] currentArray = getRandomArray(10,1,10);
int length = currentArray.Length;
Console.Write("Введите целое число N для поиска подмножеств в массиве, сумма членов подмножества которого будет равна этому числу:");
int userNumber = Convert.ToInt32(Console.ReadLine());
printArray(currentArray);

for (int countNum = 2; countNum <= length; countNum++)
{
    int position = 1;
    int Sum = 0;
    int index = 0;
    checkArray(currentArray, userNumber, index, position, countNum, Sum, length);
}

Console.WriteLine("End");

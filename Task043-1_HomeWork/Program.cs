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


int[] optimizearr (int[] incomingArray, int N) //Функция оптимизации массива, отсечение всех значений больше числа N
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

int[] currentArray = getRandomArray(20,1,11);
Console.Write("Введите целое число N для поиска подмножеств в массиве, сумма членов подмножества которого будет равна этому числу:");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] OptimArray = optimizearr(currentArray, userNumber);
printArray(currentArray);
printArray(OptimArray);
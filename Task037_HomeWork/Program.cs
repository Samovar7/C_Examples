/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] multiplyArray(int[] incomingArray) //Функция создания нового массива путем умножения крайних членов заданного массива
{
    int newLengthArray = (int)Math.Ceiling((incomingArray.Length / 2.0));
    int lengthIncomingArray = incomingArray.Length;
    int[] mArray = new int[newLengthArray];
    if (newLengthArray%2 != 0)
    {
        newLengthArray = newLengthArray -1;
        mArray[newLengthArray] = incomingArray[newLengthArray];
    }
    for (int i = 0; i < newLengthArray; i++)
    {
        mArray[i] = incomingArray[i] * incomingArray[lengthIncomingArray-1-i];
    }
    return mArray;

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

int[] userArray = generateArray(13, -10, 10);

printArray(userArray);
printArray(multiplyArray(userArray));



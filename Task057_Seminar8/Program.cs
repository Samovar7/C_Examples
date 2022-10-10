/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/



int[,] GenerateArray(int height, int weight, int deviation)
{
    int[,] generatedArray = new int[height,weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i,j] = new Random().Next(-deviation, deviation+1);
        }
    }
    return generatedArray;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void showArray(int[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j].ToString()}\t");
        }
        Console.WriteLine();
    }
}
Dictionary<int,int> GetFrequencyOfArray(int[,] inputArray)
{
    Dictionary<int,int> FrequencyDictionary = new Dictionary<int, int>();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if(FrequencyDictionary.ContainsKey(inputArray[i,j]))
            {
                 FrequencyDictionary[inputArray[i,j]] += 1; 
            }
            else
            {
              FrequencyDictionary[inputArray[i,j]] = 1; 
            }
        }
    }
    return FrequencyDictionary;
}

int[,] generatedArray = GenerateArray(5,5,10);
showArray(generatedArray);

Dictionary<int,int> frequency = GetFrequencyOfArray(generatedArray);

foreach (var item in frequency)
{
    if (item.Value > 0)
    {
        Console.WriteLine($"{item.Key} встречается {item.Value} раза ");
    }  
}

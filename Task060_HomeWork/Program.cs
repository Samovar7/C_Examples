/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] GenerateArray(int height, int weight, int depth) //Функция генерации 3-х мерного массива с уникальными 2-х значными числами
{
    int[,,] generatedArray = new int[height,weight,depth];
    if(height * weight * depth > 90)
    {
        System.Console.WriteLine("Создать массив нельзя, его размер больше чем число уникальных двухзначных чисел");
        generatedArray = new int[1, 1, 1];
        return generatedArray;
    }
       
    List<int> NumberFrom10To99 = new List<int>(90);
    for (int i = 10; i < 100; i++)
    {
        NumberFrom10To99.Add(i);
    }

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int index = new Random().Next(0, NumberFrom10To99.Count);
                generatedArray[i,j,k] = NumberFrom10To99[index];
                NumberFrom10To99.RemoveAt(index);
            }
            
        }
    }
    return generatedArray;
}
 
void PrintArray(int[,,] incomingArray) 
{
  for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            for (int k = 0; k < incomingArray.GetLength(2); k++)
            {
               Console.Write($"{incomingArray[i,j,k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
    return;
}


int[,,] userArray = GenerateArray(3,3,11);
if ((userArray.GetLength(0) + userArray.GetLength(1) + userArray.GetLength(2)) != 3)
{
    PrintArray(userArray);
}

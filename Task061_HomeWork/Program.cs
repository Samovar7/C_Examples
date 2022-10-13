/*
Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/

List<int>[] PascalTriangle (int N)
{
    List<int>[] arrayList = new List<int>[N];

    arrayList[0] = new List<int>(1);
    arrayList[0].Add(1);
    for (int i = 1; i < N; i++)
    {
        arrayList[i] = new List<int>(i+1);
        for (int j = 0; j <= i; j++)
        {
            if( j == 0)
            {
                arrayList[i].Add(1);
            }
            else if (j == i)
            {
                arrayList[i].Add(1);
            }
            else
            {
                arrayList[i].Add(arrayList[i-1][j-1] + arrayList[i-1][j]);
            }
        }
    }
    return arrayList;
}


void PrintPascalTriangle(List<int>[] arrayList)
{
    Console.Clear();
    int center = Console.WindowWidth / 2;
    int top = 1;
    for (int i = 0; i < arrayList.Length; i++)
    {
        string output = string.Join(" ", arrayList[i].ToArray());
        Console.SetCursorPosition((Console.WindowWidth / 2) - (output.Length / 2), (top + 2*i));
        Console.WriteLine(output);
        //Console.WriteLine();
        
        
    }
    Console.WriteLine();
}


int n = 15;
PrintPascalTriangle(PascalTriangle(n));
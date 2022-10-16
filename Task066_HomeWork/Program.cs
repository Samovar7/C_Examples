/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumOfDiapazon(int start, int end)
{
    int sum = start;
    if (start > end)
    {
        start = end;
        end = sum;
        sum = start;
    }
    
    if(start == end) return sum;
    sum = sum + SumOfDiapazon(start+1, end);
    return sum;

}
System.Console.WriteLine(SumOfDiapazon(8, 4));
/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/


void PrintNaturalNumbers(int n)
{
    if (n == 0) return;
    Console.Write($"{n}, ");
    PrintNaturalNumbers(n-1);
    
    return;
}

PrintNaturalNumbers(10);
Console.WriteLine();
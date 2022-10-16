/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/


int SumNumbers(int N)
{
     
   
    int lastNum = N%10;
    if (N == 0) return lastNum;
    int sum = lastNum + SumNumbers(N/10);
    return sum;
}

Console.WriteLine(SumNumbers(22222));
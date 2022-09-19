/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа. 78 -> 8 12-> 2 85 -> 8
*/
int getRandomNumberFromRange(int minBorder, int maxBorder);
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder + 1);
    return result;
}

int getMaxDigitFromNumber(int number)
{
    int maxNumber = 0;
    while (number > 0)
    {
        int maxDigit = number % 10;
        if (maxNumber < maxDigit)
        {
            maxNumber = maxDigit;
        }
        number = number / 10;
    }
    return maxNumber;
}

int randomNumber = getRandomNumberFromRange(10,99);
Console.WriteLine($"Случайное значение {randomNumber}");
int maxDigit = getMaxDigitFromNumber(randomNumber);
Console.WriteLine($"Для числа {randomNumber} большая цифра {maxDigit}");











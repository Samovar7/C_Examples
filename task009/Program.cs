//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder + 1);
    return result;
}




int randomNumber = getRandomNumberFromRange(100, 999);
Console.WriteLine($"Случайное значение {randomNumber}");
int number3 = randomNumber%10; // Получаем остаток последнюю цифру числа
int number1 = randomNumber/100;
int resultnumber = number1*10+number3;
Console.WriteLine($"Результат: {resultnumber}");

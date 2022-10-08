/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int getNumberFromUser()
{
    int result = 0;
    string userLine = "";
    while(result == 0 && userLine != "0")
    {
        userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число, вы ввели {userLine}");
        }
        
    }
    return result;
}

int Xcoordinate (int k1, int k2, int b1, int b2) // Функция расчета координаты X пересечения прямых
{
    int result = (b2 - b1) / (k1 - k2);
    return result;
}

int Ycoordinate (int k1, int b1, int x) // Функция расчета координаты Y пересечения прямых
{
    int result = k1 * x + b1;
    return result;
}

Console.WriteLine("Для вычисления точки пересечения прямых заданных следующими уравнениями \ny=k1*x+b1\ny=k2*x+b2\nвведите значения k1, k2, b1, b2:");
Console.Write("k1 = ");
int k1 = getNumberFromUser();
Console.Write("k2 = ");
int k2 = getNumberFromUser();
Console.Write("b1 = ");
int b1 = getNumberFromUser();
Console.Write("b2 = ");
int b2 = getNumberFromUser();
if (k1 != k2)
{
    int x = Xcoordinate(k1, k2, b1, b2);
    int y = Ycoordinate(k1, b1, x);
    Console.WriteLine($"Прямые пересекаются в точке x({x}),y({y})");
}
else
{
    Console.WriteLine("Эти прямые не пересекаются, они параллельны друг другу.");
}



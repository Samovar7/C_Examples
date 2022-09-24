/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

double getCoordinateFromUser(string userInformation)
{
    double result =0;
    while(result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        double.TryParse(userLine, out result);
        if (result == 0)
        {
            Console.WriteLine($"Введите число вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}
// Функция расчета длины отрезка по его координатам

double Pifagor (double X1, double Y1, double X2, double Y2)
{
    double result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    return result;
}


double userCoordinateX1 = 0;
double userCoordinateY1 = 0;
double userCoordinateX2 = 0;
double userCoordinateY2 = 0;
Console.WriteLine("Введите координаты");
userCoordinateX1 = getCoordinateFromUser("X1: ");
userCoordinateY1 = getCoordinateFromUser("Y1: ");
userCoordinateX2 = getCoordinateFromUser("X2: ");
userCoordinateY2 = getCoordinateFromUser("Y2: ");

double lengthLine = Pifagor(userCoordinateX1, userCoordinateY1, userCoordinateX2, userCoordinateY2);
Console.WriteLine($"Длина отрезка заданного координатами X1: {userCoordinateX1}, Y1: {userCoordinateY1} и X2: {userCoordinateX2}, Y2: {userCoordinateY2} составляет: {lengthLine}");

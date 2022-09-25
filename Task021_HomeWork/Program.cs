/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double getCoordinateFromUser(string userInformation) // Функция получения координат от пользователя
{
    double result =0;
    while(result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        double.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
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

double Pifagor (double X1, double Y1, double Z1, double X2, double Y2, double Z2) // Функция расчета длины отрезка по его координатам
{
    double result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
    return result;
}



Console.WriteLine("Введите координаты точки А в пространстве:");
double userCoordinateX1 = getCoordinateFromUser("X1: ");
double userCoordinateY1 = getCoordinateFromUser("Y1: ");
double userCoordinateZ1 = getCoordinateFromUser("Z1: ");
Console.WriteLine("Введите координаты точки B в пространстве:");
double userCoordinateX2 = getCoordinateFromUser("X2: ");
double userCoordinateY2 = getCoordinateFromUser("Y2: ");
double userCoordinateZ2 = getCoordinateFromUser("Z2: ");
double lengthLine = Pifagor(userCoordinateX1, userCoordinateY1, userCoordinateZ1, userCoordinateX2, userCoordinateY2, userCoordinateZ2);
Console.WriteLine($"Длина отрезка АВ заданного координатами А({userCoordinateX1},{userCoordinateY1},{userCoordinateZ1}) и В({userCoordinateX2},{userCoordinateY2},{userCoordinateZ2}) составляет: {lengthLine}");

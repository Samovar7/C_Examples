/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

 int getQuarterFromCoordinate(int coordinateX, int coordinateY)
{
    int result = 0;
    if (coordinateX > 0 && coordinateY > 0 )
    {
        result = 1;
    }
    else if (coordinateX < 0 && coordinateY > 0)
    {
        result = 2;
    }
    else if (coordinateX < 0 && coordinateY < 0)
    {
        result = 3;
    }
    else if (coordinateX > 0 && coordinateY < 0)
    {
        result = 4;
    }
    return result;
}

int getCoordinateFromUser(string userInformation)
{
    int result =0;
    while(result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

int userCoordinateX = 0;
int userCoordinateY = 0;
Console.WriteLine("Введите координаты");
userCoordinateX = getCoordinateFromUser("X: ");
//userCoordinateX = Convert.ToInt32(Console.ReadLine());
 userCoordinateY = getCoordinateFromUser("Y: ");
//userCoordinateY = Convert.ToInt32(Console.ReadLine()); 

int quater = getQuarterFromCoordinate(userCoordinateX, userCoordinateY);
if(quater > 0)
{
Console.WriteLine($"Точка с координатами [{userCoordinateX}, {userCoordinateY}] находится в {quater} четверти.");
}
else
{
    Console.WriteLine($"Одна из координат является нулевой, нельзя понять в какой четверти точка [{userCoordinateX}, {userCoordinateY}]");
}
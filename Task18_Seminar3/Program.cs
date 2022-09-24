/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

string getRangeFromQuarter(int Quarter)
{
      string result = "";
      if (Quarter == 1)
    {
        result = "Диапазон Х от 0 до +бесконечности, Y от 0 до +бесконечности";
    }
    else if (Quarter == 2)
    {
        result = "Диапазон Х от 0 до -бесконечности, Y от 0 до +бесконечности";
    }
     else if (Quarter == 3)
    {
        result = "Диапазон Х от 0 до -бесконечности, Y от 0 до -бесконечности";
    }
     else if (Quarter == 4)
    {
        result = "Диапазон Х от 0 до +бесконечности, Y от 0 до -бесконечности";
    }
    return result;
}

int getQuarterFromUser()
{
    int result =0;
    while(result <1 || result > 4)
    {
        //Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
      
        Console.WriteLine($"Введите целое число от 1 до 4 вы ввели {userLine}");
       
    }
    return result;
}

Console.Write("Введите номер четверти: ");
int userQuarter = getQuarterFromUser();
Console.WriteLine(getRangeFromQuarter(userQuarter));


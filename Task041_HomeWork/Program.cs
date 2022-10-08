/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


int sumOfPositiveUserNumber()
{
    int result = 0;
    int count = 0;
    string userLine = "";    
        do
        {
            
            userLine = Console.ReadLine();
            int.TryParse(userLine, out result);
            if (result == 0 && userLine !="0" && userLine !="exit" )
            {
                Console.WriteLine($"Введите целое число вы ввели {userLine}");
            }     
            if (result > 0) count++;
            
        } while ( userLine != "exit");
        
        
    
    return count;
}


Console.WriteLine("Введите число и нажмите 'Enter': \nЧтобы закончить ввод чисел введите exit а затем Enter.");
Console.WriteLine($"Вы ввели {sumOfPositiveUserNumber()} чисел больше 0 ");



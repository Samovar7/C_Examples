/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

bool Triangle(int AB, int BC, int AC)
{
    if (AB + BC > AC && AB + AC > BC && BC + AC > AB)
    {
        return true;
    }
    else return false;
}

Console.WriteLine("Введите значения сторон треугольника AB, BC, AC: ");
int ab = Convert.ToInt32(Console.ReadLine()); 
int bc = Convert.ToInt32(Console.ReadLine());
int ac = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Треугольник АВС со сторонами AB={ab}, BC={bc}, AC={ac}  {((Triangle(ab, bc, ac))?" ":"Не")} существует.");



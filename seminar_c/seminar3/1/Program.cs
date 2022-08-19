//  17. Напишите программу, которая принимает на
//  вход координаты точки (X и Y), причём X ≠ 0 и 
//  Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Write("Введите координату по оси Х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());
// Parse конвертирует только в Int
// Convert.ToInt32()
// null - обрабатывается в Convert.ToInt32(), предупреждения нет
// int.Parse() NULL не обрабатывает

//Shift + Alt + F форматирование пробелы
if (x > 0 && y > 0) Console.Write("I четверть ");
if (x < 0 && y > 0) Console.Write("II четверть ");
if (x < 0 && y < 0) Console.Write("III четверть ");
if (x > 0 && y < 0) Console.Write("IV четверть ");
// Console.Write("Введите координату х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// // B(x2,y2)
// Console.Write("Введите координату х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// // d = √(xb - xa)^2 + (yb - ya)^2
// double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));
// // Math.Pow(x1-x2,2) -> (x1-x2)^2
// // Math.Pow (число, степень)
// Console.WriteLine($"Расстояние между точкми: {Math.Round(result,3)}");
// // Math.Round(число, количество знаков после запятой)
// // Math.Round(result,3) - округляет переменную result до 3 знаков после запятой
// Console.WriteLine($"Результат: {result:f3}");
// // {переменная:fкол-во_знаков) -> {result:f3} - result "обрезается" до 3  знаков после запятой




int n = Convert.ToInt32(Console.ReadLine());
int start = 1;
while (start <= n)
{
    Console.WriteLine($"Квадрат от числа {start} = {Math.Pow(start,2)} ");
    start++;
}





// 1 до N
// [start;N]
int n = Convert.ToInt32(Console.ReadLine());
// int start = 1;
// while (start <= n)
// {
//     Console.WriteLine($"Квадрат от числа {start} = {Math.Pow(start,2)} ");
//     start++;
// }

// ( начало, условие для цикла, увеличение счетчика (start))
for (int start = 1; start <= n; start++)
{
    Console.WriteLine($"Квадрат от числа {start} = {Math.Pow(start,2)} ");
}






/*
int n = Convert.ToInt32(Console.ReadLine());
// int start = 1;
// while (start <= n)
// {
//     Console.WriteLine($"Квадрат от числа {start} = {Math.Pow(start,2)} ");
//     start++;
// }

// ( начало, условие для цикла, увеличение счетчика (start))
for (int start = 1; start <= n; start++)
{
    Console.Write(start*start + "\t"); // "\t" - Tab
    // Литералы - "\t"
}
Console.WriteLine();
Console.WriteLine("Текст");
Console.Write("Литерал" + "\n");
// "\n" - new string; "\n" = Console.WriteLine();
// "\t" - Tab между элементами- аналог "     "
// Итерация - разовое выполнение цикла
// for используется, когда известно количество действий
// while - когда известно условие, но не знаем кол-во
*/

/* 11.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98

12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит
остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да */



/* int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int div = num1 % num2;

if (div == 0) { Console.WriteLine("Кратно"); }
else { Console.WriteLine($"Не кратно, остаток {div}"); } */

/* int num = Convert.ToInt32(Console.ReadLine());

int div1 = num % 7;
int div2 = num % 23;

if (div1 == 0 && div2 == 0) { Console.WriteLine("Да"); }
else Console.WriteLine("Нет"); */

/* 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// //int min = Math.Min(num1, num2);
// int min = num1;
// int max = num2;

// if (num2 < num1) { min = num2; max = num1; }
// int sqr = min * min;

// if (sqr == max) { Console.WriteLine("Да"); }
// else Console.WriteLine("Нет");


//---

// 14
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" - Shift + 7 на Англ.раскладке
// // апельсины и яблоки - покупаем и то, и то обязательно
// // 1 и 1 - True(1); 1 и 0 - False(0)

// if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Кратно");
// else Console.WriteLine("Не кратно");

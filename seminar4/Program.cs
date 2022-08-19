// S
// //---
// ystem.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int Factorial(int num)
// {
//     int start = 1; 
//     int result = 1; 
//     while (start <= num)
//     {
//         result *= start;
//         //result = result * start
//         start++; 
//     }
//     return result;
// }
// if (number > 0) Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
// else System.Console.WriteLine("Введённое число не положительное");
// ///----

//   int [] array = new int[8]


// ----

//  --26 --

// int number = Convert.ToInt32(Console.ReadLine());

// int GetCountNumbers(int num)
// {
//     int count = 0; // Количество чисел
//     while (number > 0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }

// Console.WriteLine($"Количество цифр в числе {number} = {GetCountNumbers(number)}");


// //==---

// //---28---
// int number = Convert.ToInt32(Console.ReadLine());
// int GetMultiply(int num) // PascalCase 
// {
//     int start = 1; // [1;A]
//     int result = 1; // Произведение
//     while (start <= num)
//     {
//         result *= start;
//         // result += result + start
//         // result *= start => result = result * start
//         start++; // start = start + 1
//     }
//     return result;
// }
// Console.WriteLine($"Сумма чисел от 1 до {number} = {GetMultiply(number)}");


//-----

// /// ---30---


// int[] GetBinaryArray(int size) //size - количество элементов
// {
//     int[] result = new int[size]; // Массив, в котором size элементов (размер)
//     // size = 2, result = [0,0]
//     for (int i = 0; i < result.Length; i++) // result.Length = size 
//     {
//         result[i] = new Random().Next(2); // [0;1]
//     }
//     return result;
// }

// int[] array = GetBinaryArray(8);

// Console.WriteLine($"Результат: [ {String.Join(", " ,array )} ]");


// //===--

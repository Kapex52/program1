// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
 

//  //--
//  System.Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int temp1 = 0;
// int temp2 = 1;
// int fib = 1;
// System.Console.Write($"{temp1} ");
// for (int i = 2; i < number; i++)
// {
//    System.Console.Write($"{fib} ");
//    temp2 = fib;
//    fib = temp1 + temp2; 
//    temp1 = temp2;
// }
// System.Console.WriteLine($"{fib} ");


// //--

int countFibonacci = 10; // Количество чисел Фибоначчи
int firstElement = 0; // 1 число, i = 1
int secondElement = 1; // 2 число, i = 2
Console.WriteLine(firstElement);
Console.WriteLine(secondElement);
// i = 3
for (int i = 3; i <= countFibonacci; i++)
{
    int nextElement = firstElement + secondElement;
    // nextElement = 0 + 1; nextElement = 1
    Console.WriteLine(nextElement);
    firstElement = secondElement; 
    secondElement = nextElement;
}

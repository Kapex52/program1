
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



Console.Write("Введите элементы(через пробел): ");
int[] vodDanih = Console.ReadLine().Split().Select(int.Parse).ToArray();
int size = vodDanih.Length;
int count = 0;
 
for (int i = 0; i < size; i++)
{
    if (vodDanih[i] > 0)
        count++;    
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
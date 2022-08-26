
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



// Console.Write("Введите элементы(через пробел): ");
// int[] vodDanih = Console.ReadLine().Split().Select(int.Parse).ToArray();
// int size = vodDanih.Length;
// int count = 0;
 
// for (int i = 0; i < size; i++)
// {
//     if (vodDanih[i] > 0)
//         count++;    
// }
 
// Console.WriteLine($"Кол-во элементов > 0: {count}");

// bool proverka=true;
// int[] array = new int [0];
// while(proverka)
// {
//     if(Console.ReadLine().Equals("=")) {proverka=false;}// Когда будет введено "end" цикл прекратиться
// int count = 0;

//     array[count] = Convert.ToInt32(Console.ReadLine());
//     count++;

// }
// Console.WriteLine();
// Console.WriteLine(array[count]);
   // do { } while (Console.ReadKey().KeyChar != '#');


int[] array = new int [10];
int count = 0;

do
(array[count] = Convert.ToInt32(Console.ReadLine()))
    
{
   // if(Console.ReadLine().Equals("=")) {proverka=false;}// Когда будет введено "end" цикл прекратиться

    count++;

}
while (Console.ReadKey().KeyChar != '#');
Console.WriteLine();
Console.WriteLine(array[count]);

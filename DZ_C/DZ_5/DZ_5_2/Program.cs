// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите число элеменов масива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];

int sum = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100);
    Console.Write(array[i] + " ");

}
for (int j = 1; j < size; j+=2)
{
    sum=sum + array[j];
}
Console.WriteLine();
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях {sum}");

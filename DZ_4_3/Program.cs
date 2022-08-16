// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//size - количество элементов
int size = 8;
int[] MassVvod(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} число из {size}");
        result[i] = Convert.ToInt32(Console.ReadLine()); // [0;1]
    }
    return result;
}

int[] array = MassVvod(size);

Console.WriteLine($"Результат: [ {String.Join(", ", array)} ]");
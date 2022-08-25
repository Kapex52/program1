
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите сколко вы хотите ввеси чисел");
// int size = Convert.ToInt32(Console.ReadLine()); 
//double[] array =new double[]  {Console.ReadKey().KeyChar != '#'};
// int count= 0;
// for (int i = 0; i < size; i++)
// {
//     Console.WriteLine($"Введите {i+1} число( не целые числа вводить через ','");
//     array[i] = Convert.ToDouble(Console.ReadLine());  
//     Console.WriteLine(array[i] + " ");

// }
    //do { } while (Console.ReadKey().KeyChar != '#');

//   static void Main(string[] args)
//         {
//             int[] mas = new int[100];
//             int i = 0; 
//             string test;
//             int count = 0;
 
//             do
//             {
//                 test = Console.ReadLine();
//                 if (test == "end") break;
//                 mas[i] = Convert.ToInt32(test);
//                 ++i; ++count;
//             } while (true);
            
//             Console.WriteLine("Vivod: ");
//             for (int j = 0; j < count; j++)
//             {
//                 Console.Write("{0} ",mas[j]);
//             }
//             Console.ReadLine();
//         }

//  static void Main(string[] args)
//         {
//             int[] mas = new int[100];
//             int i = 0; 
//             string test;
//             int count = 0;
 
//             do
//             {
//                 test = Console.ReadLine();
//                 if (test == "end") break;
//                 mas[i] = Convert.ToInt32(test);
//                 ++i; ++count;
//             } while (true);
            
//             Console.WriteLine("Vivod: ");
//             for (int j = 0; j < count; j++)
//             {
//                 Console.Write("{0} ",mas[j]);
//             }
//             Console.ReadLine();
//         }

Console.Write("Введите элементы(через пробел): ");
String[] arr = Console.ReadLine().Split();
int[] arr2 = int.Parse(arr);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
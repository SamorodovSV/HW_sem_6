// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// internal class Program
// {
//         private static void Main(string[] args)
//     {
//         int[] CreateArray(int size)
//         {
//             int[] array = new int[size];
//             for (int i = 0; i < size; i++)
//             {
//                 Console.Write("Введите число: ");
//                 array[i] = Convert.ToInt32(Console.ReadLine());
//             }
//             return array;
//         }

//         void ShowArray(int[] array)
//         {

//             for (int i = 0; i < array.Length; i++)
//             {
//                 Console.Write(array[i] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.Clear();
//         Console.Write("Введите количество чисел: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         int[] myArray = CreateArray(num);
//         ShowArray(myArray);
//         int sum = 0;

//         for (int i = 0; i < myArray.Length; i++)
//         {
//             if (myArray[i] > 0)
//             {
//                 sum ++;
//             }
//             else 
//             {
//                 sum = sum + 0;
//             }
//          }
//            Console.WriteLine($"Пользователь ввел {sum} числа(о/ел) больше 0");
//     }
// }



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите точку начала первой прямой:");
        double b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите точку конца первой прямой:");
        double k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите точку начала второй прямой:");
        double b2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите точку конца второй прямой:");
        double k2 = Convert.ToInt32(Console.ReadLine());
        double x = (b2-b1)/(k1-k2);
        double y1 = 0;
        double y2 = 0;

        if (k1 * x + b1 == k2 * x + b2 )
        {
           y1 =  k1 * x + b1;
           y2 =  k2 * x + b2;
        }
        else
        {
            Console.WriteLine("Прямые не пересекаются!");
        }
        Console.WriteLine(y1 +"; " + y2);
    }
}
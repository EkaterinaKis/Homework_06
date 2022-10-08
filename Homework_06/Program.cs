// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2;  1, -7, 567, 89, 223 -> 4

// int[] Array = GetArray(10,-20,20);
// Console.WriteLine(String.Join(" ", Array));

// int count = 0;
// for (int i=0; i<Array.Length; i++)
// {
//     if(Array[i]>0)
//     {
//     count++;
//     }
// }
// Console.WriteLine($"Количество чисел больше 0 в массиве: {count}");

// int[] GetArray(int size, int MinValue, int MaxValue)
// {
//     int[] res = new int[size];
//     for (int i =0; i<size; i++)
//     {
//         res [i]= new Random().Next(MinValue,MaxValue+1);
//     }
//     return res;
// }

// //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите число b1: ");
// double b1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число k1: ");
// double k1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число b2: ");
// double b2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число k2: ");
// double k2 = int.Parse(Console.ReadLine()!);
// double x = 0;
// double y = 0;
// if (k1 != k2 && b1 != b2)
// {
//     x = (b2 - b1) / (k1 - k2);
//     y = k1 * (b2 - b1) / (k1 - k2) + b1;
//     Console.WriteLine($"Точка пересечения прямых: ({x};{y})");
// }
// else 
// {
//     if (k1 == k2 && b1 != b2)
//     {
//         Console.WriteLine("Прямые параллельные и не имеют точек пересечения!");
//     }
//     if (b1 == b2)
//     {
//         Console.WriteLine("Прямые полностью совпадают!");
//     }
// }


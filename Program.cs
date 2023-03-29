// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// int quantity;

// Console.Write("Укажите сколько чисел вы хотите ввести");

// int.TryParse(Console.ReadLine(), out quantity);

// int[] arrNumber = new int[quantity];

// for (int i = 0; i < arrNumber.Length; i++)
// {
//     Console.Write($"Введите число под номером {i+1}");
//     int.TryParse(Console.ReadLine(), out arrNumber[i]);
// }

// Console.WriteLine($"Вы ввели {CalcCount(arrNumber)} чисел больше 0");

// int CalcCount(int[] arr)
// {
//     int res =0;
//     for (int i = 0; i < arr.Length; i++)
//         if(arr[i]> 0) res +=1;
//     return res;
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

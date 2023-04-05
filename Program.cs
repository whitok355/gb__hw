// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int row, col;

// Console.Write("Введите количество строк");
// int.TryParse(Console.ReadLine(), out row);
// Console.Write("Введите количество столбцов");
// int.TryParse(Console.ReadLine(), out col);

// int[,] arr = new int[row, col];

// FillArr();
// PrintArr();
// SortArr();
// PrintArr();

// void FillArr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(10);
//         }
//     }
// }

// void SortArr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1) - 1; j++)
//         {
//             for (int z = 0; z < arr.GetLength(1) - 1; z++)
//             {
//                 if (arr[i, z] < arr[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
//                 {
//                     int temp = 0;
//                     temp = arr[i, z];
//                     arr[i, z] = arr[i, z + 1];
//                     arr[i, z + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintArr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int k = 0; k < arr.GetLength(1); k++)
//         {
//             Console.Write(arr[i,k]);
//         }
//         Console.WriteLine();
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

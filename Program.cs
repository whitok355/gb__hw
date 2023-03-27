//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.

// int [] arr = new int[4];
// int count = 0;

// for(int i = 0; i< arr.GetLength(0); i++)
// {
//     arr[i] = new Random().Next(100, 1000);
// }

// for(int j = 0 ; j < arr.GetLength(0); j++)
// {
//     int first = arr[j] / 100 != 0 ? (arr[j] / 100) % 2 : 1;
//     int second = arr[j] % 100 / 10  != 0 ? (arr[j] % 100 / 10) % 2 : 1;
//     int thrid =  arr[j] %10 != 0 ? (arr[j] %10) % 2 : 1;

//     if(first == 0)
//     {
//         count+=1;
//     }
//     if(second == 0)
//     {
//         count+=1;
//     }
//     if(thrid== 0)
//     {
//         count+=1;
//     }
// }

// Console.WriteLine($"{arr[0]}    {arr[1]}    {arr[2]} {arr[3]}");
// Console.WriteLine(count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int [] arr36 = {3, 7, 23, 12};
// int sum = 0;

// for(int i = 0; i < arr36.GetLength(0); i++)
// {
//     arr36[i] = new Random().Next(0,10);
// }

// for(int j = 0; j < arr36.GetLength(0); j++)
// {
//     if(j % 2 != 0)
//     {
//         sum += arr36[j];
//     }
// }
// Console.WriteLine($" answer {sum}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int[] arr38 = new int[5];

// for(int k = 0; k < arr38.GetLength(0); k++)
// {
//     arr38[k] = new Random().Next(0, 100);
// }

// int max = arr38[0];
// int min = arr38[0];

// for(int j = 1; j < arr38.GetLength(0); j++)
// {
//     if(arr38[j] > max)
//     {
//         max = arr38[j];
//     }
//     if(min > arr38[j])
//     {   
//         min = arr38[j];
//     }
// }

// Console.WriteLine($"Answer {max - min}");
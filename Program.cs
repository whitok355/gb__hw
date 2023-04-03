﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int row;
int col;

Console.Write("Введите число строк");
int.TryParse(Console.ReadLine(), out row);
Console.Write("Введите число столбцов");
int.TryParse(Console.ReadLine(), out col);

int[,] arr = new int[row, col];
FillArr(arr);
PrintArray(arr);
void FillArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int findRow, findCol;
Console.Write("Введите строку искомого числа ");
int.TryParse(Console.ReadLine(), out findRow);
Console.Write("Введите столбец искомого числа ");
int.TryParse(Console.ReadLine(), out findCol);

int res = FindValue(arr, findRow-1, findCol-1);

int FindValue(int[,] array, int row, int col)
{
    return array[row, col];
}

Console.WriteLine(res);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Calc(arr);

void Calc(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int res = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i, j];
        }
        Console.WriteLine(res);
    }
}
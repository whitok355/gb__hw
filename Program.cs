// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int num;

// Console.Write("Please enter number ");
// int.TryParse(Console.ReadLine(), out num);

// PrintNum(num);

// void PrintNum(int val)
// {
//     if(val > 0)
//     {
//         Console.WriteLine(val);
//         PrintNum(val - 1);
//     }
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m, n;

// Console.Write("Please anter number M");
// int.TryParse(Console.ReadLine(), out m);
// Console.Write("Please anter number N");
// int.TryParse(Console.ReadLine(), out n);

// FindMax();

// void FindMax()
// {
//     int max = m > n ? m : n;
//     int min = m < n ? m : n;
//     int sum = min;
//     while(min < max)
//     {
//         sum += min + 1;
//         min++;
//     }
//     Console.WriteLine(sum);
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int m, n;

// Console.Write("Please anter number M");
// int.TryParse(Console.ReadLine(), out m);
// Console.Write("Please anter number N");
// int.TryParse(Console.ReadLine(), out n);

// int resAck = Ack(m,n);

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// Console.WriteLine(resAck);

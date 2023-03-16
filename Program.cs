//Task 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Please enter random number");
string number = Console.ReadLine();
int length = number.Length;

if(length == 5){
    if(number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Число является палиндромом");
    } else 
    {
        Console.WriteLine("Число не является палиндромом");
    }
} else
{
    Console.WriteLine("Число не пятизначное");
}




//Task 21
// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double a = Math.Pow((x2 - x1), 2);
double b = Math.Pow((y2 - y1), 2);
double c = Math.Pow((z2 - z1), 2);

double length = Math.Sqrt(a+b+c);

Console.WriteLine(length);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Please enter number");

int numb = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= numb; i++)
{
    Console.WriteLine($"Введенное число {numb}, таблицу кубов чисел от 1 до N. {i * i * i}");
}
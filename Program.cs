int rand = new Random().Next(10, 1000);

//Task10

Console.WriteLine($"random number {rand} вторая цифра числа = {rand % 100 / 10 }");

//Task 13
if(rand / 100 == 0)
{
    Console.WriteLine($"random number {rand} третьей цифры нет.");
} else
{
    Console.WriteLine($"random number {rand} третья цифра {rand % 10}.");
}

//Task 15

int day = new Random().Next(1,8);

if(day == 6 || day == 7)
{
    Console.WriteLine($"Случайное число {day}, является выходным");
} else
{
    Console.WriteLine($"Случайное число {day}, не является выходным");
}
// See https://aka.ms/new-console-template for more information

//Task 2
// int numberA, numberB;
// int max;

// Console.Write("Please enter first  number");
// int.TryParse(Console.ReadLine()!, out numberA);

// Console.Write("Please enter second number");
// int.TryParse(Console.ReadLine()!, out numberB);

// if(numberA > numberB)
// {
//     max = numberA;
// } else
// {
//     max = numberB;
// }


// Console.WriteLine($"A larger number: {max}");


// Task 2 / Task 4

// int [] arrayNumbers = new int[4];
// int index = 0;

// while(index < arrayNumbers.Length){
//     Console.Write("Enter number");
//     int.TryParse(Console.ReadLine()!, out arrayNumbers[index]);
//     index++;
// }

// int max = arrayNumbers[0];
// index = 0;
// int nextIndex = 1;
// while(nextIndex < arrayNumbers.Length)
// {
//     if(max < arrayNumbers[nextIndex])
//     {
//         max = arrayNumbers[nextIndex];
//     }
//     index++;
//     nextIndex++;
// }

// Console.WriteLine(max);

//Task 6

// int number;

// Console.Write("Please enter number");

// int.TryParse(Console.ReadLine()!, out number);

// if(number%2 != 0)
// {
//     Console.WriteLine($"The number you entered - {number}, is number not an even number");
// } else
// {
//     Console.WriteLine($"The number you entered - {number}, is number an even number");
// }

//Task8

// int number;
// Console.WriteLine("Please enter your number");

// int.TryParse(Console.ReadLine()!, out number);

// for(int i =1; i <= number; i++)
// {
//     if(i % 2 == 0)
//     {
//         Console.Write(i);
//     }
// }

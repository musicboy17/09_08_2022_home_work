// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
//
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = number / 10;
int exit1 = digit % 10;
Console.WriteLine(exit1);


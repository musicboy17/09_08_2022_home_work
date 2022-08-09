// // Задача 13: Напишите программу, которая выводит 
// // третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6

Console.WriteLine("Введите число N от 1 до 999999: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1000000)
{
    Console.WriteLine($"Слишком большое число!!!");
}
if (number < 1000000 && number >100000)
{
int digit05 = number / 1000;
int digit051 = digit05 % 10;
Console.WriteLine($"{digit051}");
}
if (number < 100000 && number > 10000)
{int digit1 = number / 100;
int digit11 = digit1 % 10;
Console.WriteLine($"{digit11}");
}
if (number < 10000 && number > 1000)
{int digit2 = number / 10;
int digit21 = digit2 % 10;
Console.WriteLine($"{digit21}");
}
if (number < 1000 && number > 100)
{int digit3 = number;
int digit31 = digit3 % 10;
Console.WriteLine($"{digit31}");
}
if (number < 100)
{int digit4 = number % 10;
int digit41 = digit4 % 10;
Console.WriteLine($"Нет третьей цифры!!!");
}

/*{digit051} {digit11} */

// int[] arr1= new int[10];

// Console.Write("Введите число N от 0 до 100000: ");
// int number = Convert.ToInt32(Console.ReadLine());


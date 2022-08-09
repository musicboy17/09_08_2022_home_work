// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели - от 1 до 7 : ");

int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(number);

if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine("Рабочий день");
}
if (number == 6 || number == 7)
{
    Console.WriteLine("Неабочий день");
}
if (number != 1 && number !=2 && number != 3 && number != 4 && number != 5 && number != 6 && number != 7) 
{    
    Console.WriteLine("Вы ввели некорректное число!");
}


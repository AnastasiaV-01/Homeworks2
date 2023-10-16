// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num >= 100 && num <= 999)
// {
//     System.Console.WriteLine($"{num} -> {(num / 10) % 10}");
// }
// else
// {
//     System.Console.WriteLine("You input not three-digit number");
// }




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num >= 100 && num <= 999)
// {
//     System.Console.WriteLine($"{num} -> {num % 10}");
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// System.Console.WriteLine("Введите номер от 1 до 7: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if(n >= 6 && n < 8)
// {
//     System.Console.WriteLine("Это выходной день недели");
// }
// else if(n < 6)
// {
//     System.Console.WriteLine("Это рабочий день недели");
// }


// System.Console.WriteLine("Введите номер от 1 до 7: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if(n >= 6 && n < 8)
// {
//     System.Console.WriteLine("Да");
// }
// else if(n < 6)
// {
//     System.Console.WriteLine("Нет");
// }
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





// УРОК 4. ФУНКЦИИ

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int numberA = ReadInt("Введите число: ");
// int numberB = ReadInt("Введите степень: ");
// Degree(numberA, numberB);

//  void Degree(int a, int N)
//  {
//    int result = 1;
//    for(int i = 1; i <= N; i++)
//    {
//     result = result * a;
//    }
//    System.Console.WriteLine(a + " в степени " + N + " = " + result); 
//  }
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }





// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int number = ReadInt("Введите число: ");

// int len = NumberLen(number);
// SumNumbers(number, len);

// // Функция подсчета цифр в числе
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// // Функция вывода суммы цифр в числе
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i=1; i <= len ;i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine($"сумма цифр {sum}");
// }

// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int LenArray = ReadInt("Введите длинну массива: ");
// int[] RandomArray = new int[LenArray];
// {
//     for(int i = 0; i < RandomArray.Length; i++)
//     {
//         RandomArray[i] = new Random().Next(1,99);
//         System.Console.Write(RandomArray[i] + " ");
//     }
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }





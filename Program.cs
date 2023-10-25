// Урок 6. Одномерные массивы. Продолжение

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// System.Console.Write("Введите количество элементов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[m];

// void massiv(int m)
// {
//   for (int i = 0; i < m; i++)
//    {
//      System.Console.WriteLine($"Введите {i+1} элемент массива ");
//      Array[i] = Convert.ToInt32(Console.ReadLine());
//    }
// }

// int quantity(int[] Array)
// {
//   int i = 0;
//   int sum = 0;
//   while (i < Array.Length)
//    {
//      if(Array[i]>0)
//     sum = sum + 1;
//     i = i + 1;
//    }
//    return sum;
// }

// massiv(m);
// System.Console.Write($"\n Чисел больше нуля: {quantity(Array)}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите переменную b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = ((b2 - b1) / (k1 - k2));
// double y = k1 * x + b1;

// Console.Write($"\n Точка пересечения двух прямых: [{x},{y}]");
























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





﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumber(int start, int end)
// {
//     if(start == end) return Convert.ToString(start);
//     return (start + " " + PrintNumber(start - 1, end));
// }

// Console.Write($"{N} -> ");
// Console.Write(PrintNumber(N, 1));

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumNum (int M, int N)
// {
//     if (M == N) return M;
//     return M + SumNum(M+1, N);
// }

// Console.WriteLine($"Сумма чисел от {M} до {N} равна {SumNum(M, N)}");
﻿// Задача 64: Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = InputNumbers("Введите N: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
 if (count > n) return;
 PrintNumber(n, count + 1);
 Console.Write(count + ", ");
}

int InputNumbers(string input)
{
 Console.Write(input);
 int output = Convert.ToInt32(Console.ReadLine());
 return output;
}
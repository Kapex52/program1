﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Треугольник существует");

else Console.WriteLine("Треугольник НЕ существует");

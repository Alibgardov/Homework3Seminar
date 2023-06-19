﻿Console.Clear();
Console.WriteLine("Введите X первой точки:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y первой точки:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z первой точки:");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите X второй точки:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y второй точки:");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z второй точки:");
double z2 = double.Parse(Console.ReadLine());
Console.WriteLine ($"расстояние равно {Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2)):f2}");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53 4 3 1 6 4 2 


﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// d= AB = √(x1 - x2)2 + (y1 - y2)2 + (z1 - z2)2


// функция расчёта и возврата результата
double GetDistanceThreePoint(int x1, int y1, int z1, int x2, int y2, int z2) 
{
    double distanse = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

    return distanse;
}


// вводим числа координат
Console.Write("Введите X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите Z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Введите Z2: ");
int z2 = int.Parse(Console.ReadLine());

// Расчет расстояния между двумя точками на плоскости в 3D
double result = GetDistanceThreePoint(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2} и ({z1}, {z2}) равно {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");


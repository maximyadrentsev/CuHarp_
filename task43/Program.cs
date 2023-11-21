﻿/*
Напишите программу которая найдет персечение двух прямых, заданных уравненеий
*/

Console.Clear();

System.Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введиете число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void CrossLine(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2) 
            System.Console.WriteLine("прямые совпадают");
        else
             System.Console.WriteLine("прямые паралельны");
             return;
    }
    
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    System.Console.WriteLine($"Две прямые пересекаются в точке с координатами X: {x}, Y: {y}");
}

CrossLine(b1, k1, b2, k2);
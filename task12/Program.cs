﻿/*
Напишите программу, которая будет принемать на вход два числа и выводить, 
является первое число кратным первому.
Если второе число не кратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

System.Console.WriteLine("Введите, первое число! ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число! ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2 * number2)
{
    System.Console.WriteLine("да, второе число является кратным первому ");
}
else
{
    System.Console.WriteLine(number1 % number2);
    System.Console.WriteLine("нет, второе число не является кратным первому ");
}
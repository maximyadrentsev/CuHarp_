/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введи число");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 5 && number > 0)
{
    System.Console.WriteLine("нет " + number);
}
if(number == 6 || number == 7)
{
    System.Console.WriteLine("да " + number);
}
else if(number > 7 || number < 1)
{
    System.Console.WriteLine("Error");
}
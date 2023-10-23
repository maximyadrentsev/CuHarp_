/*
Напишите программу, которая принемает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25/
2 -> 1, 4.

*/

Console.Clear();

void Numbern(int numb)
{
    for (int i = 1; i <= numb; i++)
    {
        System.Console.WriteLine($"{i} * {i} = {i * i} "); // $ интерполяция значения
    }
}


System.Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

Numbern(num);

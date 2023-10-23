/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


Console.Clear();
System.Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

int Numbers(int num)
{
    int summ = 0;
    int resalt = 0;
    for (int i = num; i > 0; i = i / 10)
    {
        resalt = i % 10;
        summ = summ + resalt;
    }
    return summ;
}
int userresalt = Numbers(numb);
Console.WriteLine("Сумма цифр в числе " + userresalt);

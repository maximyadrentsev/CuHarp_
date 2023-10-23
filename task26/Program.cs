/*
Напишите программу, которая принемает на вход число и выдает количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Numbers(int num)
{
    int result = 0;
    for (int i = num; i > 0; i = i / 10)
    {
        result = result + 1;
    }
    return result;
}

int userresalt = Numbers(number);
Console.WriteLine(userresalt);
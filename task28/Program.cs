/*
Напишите программу, которая принемает на вход 
число N и выдает произведение чисел от 1 до N/

4 -> 24
5 -> 120
*/ 

Console.Clear();


int Factorial(int num)
{
    int resalt = 1;
    for (int i = 1; i <= num ; i++)
    {
        resalt = resalt * i;
    }

    return resalt;

}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int userresalt = Factorial(number);
Console.WriteLine($"факториал числа {number} = "  + userresalt);
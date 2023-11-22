/*
Задайте значение N. Напишите программу, котороя выведет
все натуральные числа в промежутке от 1 до N.
*/ 


Console.Clear();

void DigitDiapas(int n, int start = 1)
{
    if (start > n )
    {
        return;
    }
    else 
    {
        System.Console.Write(start + " ");
        DigitDiapas(n, start + 1);// Вызываем рекурсию 
    }
}

DigitDiapas(5);
/*
Задайте хначение  M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
*/ 

Console.Clear();

void DigitDiapas(int n, int start)
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

DigitDiapas(20, 2);

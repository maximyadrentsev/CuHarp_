/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/ 



Console.Clear();

int Step(int digit, int square)
{
    if(square == digit)
    {
        return digit;
    }
    else
    {
        return digit + Step(digit + 1, square);
    }
}
 
int resalt = Step(1, 15);
System.Console.WriteLine(resalt);
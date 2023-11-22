/*
Напишите программу, которая на входе принимает
два числа А и В, и возводит число А в 
целую степень В с помощью рекурсии.
*/


Console.Clear();

int Step(int digit, int square)
{
    if(square == 1)
    {
        return digit;
    }
    else
    {
        return digit * Step(digit, square - 1);
    }
}
 
int resalt = Step(3, 9);
System.Console.WriteLine(resalt);
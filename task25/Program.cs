/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();

System.Console.WriteLine("Введите число возводимое в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральную степень: ");
int B = Convert.ToInt32(Console.ReadLine());
/*
void Squarenumber(int A, int B) метод с использованием Math.Pow
{
Console.WriteLine(Math.Pow(A, B));
}
Squarenumber(A, B);
*/

void Squarenumber(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
        
    }
    System.Console.WriteLine(result);
}

Squarenumber(A, B);
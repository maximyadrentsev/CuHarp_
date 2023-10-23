/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();
System.Console.WriteLine("Введите число возводимое в степень и натуральную степень: ");


void Squarenumber()
{
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Pow(A, B));
}
Squarenumber();


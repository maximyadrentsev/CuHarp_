/*
Внутри класса Answer напишите метод DistanceBetweenPoints, 
который принимает на вход координаты двух точек pointA и pointB 
в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.Clear();


System.Console.Write("Задать кординату точки А х ");
int userAx = int.Parse(Console.ReadLine());
System.Console.Write("Задать кординату точки А y ");
int userAy = int.Parse(Console.ReadLine());
System.Console.Write("Задать кординату точки А z ");
int userAz = int.Parse(Console.ReadLine());

System.Console.Write("Задать кординату точки B х ");
int userBx = int.Parse(Console.ReadLine());
System.Console.Write("Задать кординату точки B y ");
int userBy = int.Parse(Console.ReadLine());
System.Console.Write("Задать кординату точки B z ");
int userBz = int.Parse(Console.ReadLine());

//int sqrX = (userBx - userAx)*(userBx - userAx);
double sqrX = Math.Pow(userBx - userAx, 2); // Math.Pow(a ,  2)  функция возводит в степень (переменная , в какую степень надо возвести)

double sqrY = Math.Pow(userBy - userAy, 2); 

double sqrZ = Math.Pow(userBz - userAz, 2); 

double sqrt = Math.Sqrt(sqrX + sqrY + sqrZ); // Math.Sqrt Выводим квадратный корень из чмсла 
System.Console.WriteLine(Math.Round(sqrt, 2));// Math.Round округляет десятичное число (переменная, сколько знаков после запятой оставить)

/*
Напишите программу, которая принемает на вход координаты точки (X и Y),
причем x =/ 0 и y =/ 0
и выдает номер четверти плоскости, в которой находится эта точка.
X=34; Y=30 -> 4
X=2; Y=4 -> 1
X=-34; Y=-30 -> 3
*/

Console.Clear();
System.Console.Write("задай координату точки X:  ");
int userX = int.Parse(Console.ReadLine());
System.Console.Write("задай координату точки Y:  ");
int userY = int.Parse(Console.ReadLine());

if (userX > 0 && userY > 0)
{
    System.Console.WriteLine("точка находится в первой четверти");
}
if (userX < 0 && userY > 0)
{
    System.Console.WriteLine("точка находится во второй четвети");
}
if (userX < 0 && userY < 0)
{
    System.Console.WriteLine("точка ноходится в третьей четверти");
}
if (userX > 0 && userY < 0)
{
    System.Console.WriteLine("точка ноходится в четвертой четверти");
}
if (userX == 0 || userY == 0)
{
    System.Console.WriteLine("точка ноходится на оси координат");
}




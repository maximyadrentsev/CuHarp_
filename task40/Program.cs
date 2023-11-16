Console.Clear();
string Triangel(int a, int b, int c)

{
    string result = $"Нет, треугольника со сторанами {a}, {b}, {c} не существует";
    if(a + b > c & b + c > a & a + c > b)
    {
        result = $"Нет, треугольника со сторанами {a}, {b}, {c} существует";
    }
    return result;
}

System.Console.WriteLine(Triangel(3, 2, 4));
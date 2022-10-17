int a, b, c, d, e, f;
Console.WriteLine("Введите координаты коня от 1 до 8");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты слона от 1 до 8");
c = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты хода коня");
e = int.Parse(Console.ReadLine());
f = int.Parse(Console.ReadLine());

if ((a + 1 == e && b + 2 == f) ||
    (a - 1 == e && b + 2 == f) ||
    (a + 1 == e && b - 2 == f) ||
    (a - 1 == e && b - 2 == f) ||
    (a + 2 == e && b + 1 == f) ||
    (a - 2 == e && b + 1 == f) ||
    (a + 2 == e && b - 1 == f) ||
    (a - 2 == e && b - 1 == f)) //перебирает варианты ходов коня
{
    if (((c - e) == (d - f)) || ((c - e) == (f - d))) //проверяет под ударом ли конь
    {
        Console.WriteLine("Конь может сходить в это место, но попадает под удар");
    }
    else 
        Console.WriteLine("Конь может сходить туда не попадая под удар");
}
else
{
    Console.WriteLine("Конь так не может пойти");
}
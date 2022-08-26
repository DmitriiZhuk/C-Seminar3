/*
Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
// расстояние считается sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)
Console.Write("Введите координату Х точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х точки B ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distanse = Math.Round(
    Math.Sqrt(
    Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)
            )
    , 2);

Console.WriteLine("Расстояние между А и В равно: " + distanse);
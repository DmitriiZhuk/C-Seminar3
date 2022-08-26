/*
Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Write("Введите на вход число (N): ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

for (int i = 1; i <= N; i++)
{
    array[i - 1] = i * i * i;
    Console.Write(array[i - 1] + " ");
}
Console.WriteLine("");

/* Универсальное решение для степеней
Console.Write("Введите на вход число (N): ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
double pow = Convert.ToDouble(Console.ReadLine());

double[] array = new double[N];

for (int i = 1; i <= N; i++)
{
    array[i - 1] = Math.Pow(i, pow);
    Console.Write(array[i - 1] + " ");
}
Console.WriteLine("");
*/

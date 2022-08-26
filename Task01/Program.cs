/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string)
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите число для проверки: ");
int numToCheck = Convert.ToInt32(Console.ReadLine());

int sum = 0;  // переменная, куда будут складываться "обратные" результаты для вычисления палиндрома
int restToDiv; // переменная для остатков от деления
int numToCheckClone = numToCheck;  // потому что далее numToCheck меняется

while (numToCheck > 0)
{
    restToDiv = numToCheck % 10;
    //Console.WriteLine("restToDiv " + restToDiv);

    sum = (sum * 10) + restToDiv;
    //Console.WriteLine("sum " + sum);

    numToCheck = numToCheck / 10;
    //Console.WriteLine("numToCheck " + numToCheck);

}

if (numToCheckClone == sum)
{
    Console.WriteLine("Число - палиндром");
}
else
{
    Console.WriteLine("Число - не палиндром");
}

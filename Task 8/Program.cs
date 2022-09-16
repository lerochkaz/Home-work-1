// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
String number = Console.ReadLine();
int num = int.Parse(number);

if (num < 2)
{
    if (num >= 0)
    {
        Console.Write("Четных чисел нет");
    }
    else
    {
        Console.Write("Положительных чисел нет");
    }
}
else
{
    for (int i = 2; i <= num; i = i + 2)
    {
        Console.WriteLine(i);
    }
}
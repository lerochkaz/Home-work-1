// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
String numberOne = Console.ReadLine();
int first = int.Parse(numberOne);
Console.Write("Введите второе число: ");
String numberTwo = Console.ReadLine();
int second = int.Parse(numberTwo);
Console.Write("Введите третье число: ");
String numberThree = Console.ReadLine();
int third = int.Parse(numberThree);

if (first > second)
{
    if (first > third)
    {
        Console.WriteLine(first);
    }
    else
    {
        Console.WriteLine(third);
    }
}
else
{
    if (second > third)
    {
        Console.WriteLine(second);
    }
    else
    {
        Console.WriteLine(third);
    }
}

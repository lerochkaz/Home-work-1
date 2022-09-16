// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7 min = 5
// a = 2 b = 10 -> max = 10 min = 2
// a = -9 b = -3 -> max = -3 min = -9

Console.Clear();
Console.Write("Введите первое число: ");
String numberOne = Console.ReadLine();
int first = int.Parse(numberOne);
Console.Write("Введите второе число: ");
String numberTwo = Console.ReadLine();
int second = int.Parse(numberTwo);
if (first > second)
{
    Console.WriteLine($"max={first} min={second}");
}
else if (first < second)
{
    Console.WriteLine($"max={second}, min={first}");
}
else
{
    Console.WriteLine("Числа равны");
}


// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:   ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:   ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Число {a} большее, число {b} меньшее");
}
if (b > a)
{
    Console.WriteLine($"Число {b} большее, число {a} меньшее");
}
if (a == b)
{
    Console.WriteLine($"Числа равны");
}

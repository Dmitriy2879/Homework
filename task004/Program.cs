// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:  ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0)
{
    Console.WriteLine("Введите положительное число, больше нуля");
}
int dok = 2;
while (dok <= N)
{
    if (dok % 2 == 0)
    {
        Console.Write(dok + "  ");
    }
    dok++;
}

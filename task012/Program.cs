// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B (и в нулевую степень).
// Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:   ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень для числа:   ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < b; i++)
{
    result *= a;
}
Console.WriteLine("Результат: {0} ^ {1} = {2}", a, b, result);
return 0;

// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double InputNum(string msg)
{
    Console.WriteLine(msg);
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double k1 = InputNum("Введите коэффциент k1:  ");
double b1 = InputNum("Введите число b1:  ");
double k2 = InputNum("Введите коэффциент k2:  ");
double b2 = InputNum("Введите число b2:  ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(x, 3);
System.Console.WriteLine($"Пересечение в точке: ({x};{y})");

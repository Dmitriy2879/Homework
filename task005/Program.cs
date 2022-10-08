// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Promt(string messange)
{
    Console.WriteLine(messange);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Promt("Введите трехзначное число:   "); // вводим число

int number2 = 0;
if (number > 99 & number < 1000) // диапазон
{
    number2 = (number / 10) % 10; // число 546/10= 54, остаток от деления 54%10 = 4 т.е. вторая цифра
    Console.WriteLine($"Вторая цифра этого числа: {number2}"); // вывели на экран
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}

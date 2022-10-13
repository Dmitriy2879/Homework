// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string msg)
{
    Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}
int number = InputNumber("Введите число:  ");
int result = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе равна: {result}");

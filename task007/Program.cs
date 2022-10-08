// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Promt(string messange)
{
    Console.WriteLine(messange);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Promt("Введите число:   "); // вводим число
int number3 = 0;
if (number < 100) // диапазон
{
    Console.WriteLine("В этом числе отсутствует третья цифра"); // вывели на экран
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    number3 = number % 10;  //отсекаем третью цифру
    Console.WriteLine($"Третья цифра этого числа: {number3}");
}

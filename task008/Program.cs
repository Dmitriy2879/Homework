// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Promt(string messange)
{
    Console.WriteLine(messange);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int day = Promt("Введите номер дня недели:   "); // вводим число от 1 до 7
if (day > 0 & day < 6) // диапазон
{
    Console.WriteLine("Это будний день");
}
else if (day > 5 & day <= 7) // диапазон
{
    Console.WriteLine("Сегодня выходной!");
}
else 
{
    Console.WriteLine("Такого дня недели не существует");
}

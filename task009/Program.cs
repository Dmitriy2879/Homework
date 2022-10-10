// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int Promt(string messange)
{
    Console.WriteLine(messange);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Promt("Введите пятизначное число:   "); // вводим число

int num1 = number / 10000;     // находим первое чсло
int num2 = number / 1000 % 10; // второе число
int num4 = number / 10 % 10;   // четвертое число
int num5 = number % 10;        // пятое число

int res1 = (num1 - num5);
int res2 = (num2 - num4);

int result = res1 + res2;

string num = "12345";          // использую .Length и конвертирую в строку
int length = num.Length;

if (num.Length == 5)
{
    if (result == 0)
    {
        Console.WriteLine("Это число является палиндром");
    }
    else
    {
        Console.WriteLine("Это число не является палиндром");
    }
}


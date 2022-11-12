// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int m = InputNumbers("Введите значение M:  ");
int n = InputNumbers("Введите значение N:  ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintEven(int m, int n)
{
    if (n % 2 == 0)
    {
        Console.Write(n + " ");
        return;
    }
    PrintEven(m, n + 1);
}

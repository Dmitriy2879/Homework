// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите размер массива:  ");
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int[,] array = new int [N,M];
Random rnd = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rnd.Next(1,10);
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Введите позицию элемента");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (a>N || b>M)
Console.WriteLine("Такого числа нет");
else
{
    object c = array.GetValue(a,b);
    Console.WriteLine(c);
}



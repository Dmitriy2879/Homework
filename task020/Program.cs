// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray(int Row, int Columns)
{
    double[,] array = new double[Row,Columns]; // объявить массив
    Random rnd = new Random(); //генератор случайных чисел
    for (int i = 0; i < array.GetLength(0); i++) // условие
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-5, 5) + rnd.NextDouble();
        }
    }
    return array; //возвращаем массив
}

void PrintArray(double[,] array) //вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f2}\t"); // массив в строчку
        }
        Console.WriteLine();
    }
}
double[,] array = CreateArray(3,4);
PrintArray(array);

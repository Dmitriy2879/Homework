// Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию 
// элементы каждой строки двумерного массива.

int[,] CreateArray(int row, int column)
{
    int[,] array = new int[row, column]; // объявить массив
    Random rnd = new Random(); //генератор случайных чисел
    for (int i = 0; i < array.GetLength(0); i++) // условие
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-5, 5);
        }
    }
    return array; //возвращаем массив
}

void PrintArray(int[,] array) //вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t"); // массив в строчку
        }
        Console.WriteLine();
    }
}

void OrderArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k+1])
                {
                    int temp = array[i, k+1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int [,] array = CreateArray(3,4);
PrintArray(array);
Console.WriteLine();
OrderArray(array);
PrintArray(array);

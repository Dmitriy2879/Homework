// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

int m = InputNumbers("Введите колличество строк первой матрицы:  ");
int n = InputNumbers("Введите колличество столбцов первой матрицы (строк второй матрицы):  ");
int p = InputNumbers("Введите колличество столбцов второй матрицы:  ");
int range = InputNumbers("Введите диапазон матрицы от 1:  ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix);
Console.WriteLine($"Первая матрица: ");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
CreateArray(secondMatrix);
Console.WriteLine($"Вторая матрица: ");
PrintArray(secondMatrix);

int[,] sumMatrix = new int[m, p];

MultiMatrix(firstMatrix, secondMatrix, sumMatrix);
Console.WriteLine($"Произведение матриц: ");
PrintArray(sumMatrix);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // условие
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
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

void MultiMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] sumMatrix)
{
    for (int i = 0; i < sumMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < sumMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i,k] * secondMatrix[k,j];
            }
            sumMatrix[i,j] = sum;
        }
    }
}
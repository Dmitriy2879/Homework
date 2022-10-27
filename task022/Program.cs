// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите размер массива:  ");
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int[,] array = new int [N,M];
Random rnd = new Random();

int[] summ = new int[M];

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        array[i,j] = rnd.Next(0,10);
    }
}

Console.WriteLine();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write($"{array[i,j]}\t");
        summ[j]+=array[i,j];
    }
    Console.WriteLine();
}
Console.WriteLine();

foreach (double elem in summ)
{
    Console.WriteLine($" {(elem/N):f2}");
}


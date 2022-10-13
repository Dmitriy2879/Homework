// Напишите программу, которая задаёт массив из 8 случайных элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8

Show(Complete(8));

int[] Complete(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int b = new Random().Next(1, 100);
        array[i] = b;
    }
    return array;
}
void Show(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

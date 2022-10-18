// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int len, int minLimit, int maxLimit) // создаем массив
{
    double[] array = new double[len]; // объявить массив
    Random rnd = new Random(); //генератор случайных чисел
    for (int i = 0; i < array.Length; i++) // условие
    {
        array[i] = rnd.Next(minLimit, maxLimit) + rnd.NextDouble(); //от мин до максим 
    }
    return array; //возвращаем массив
}

void PrintArray(double[] array) //вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2}\t"); // массив в строчку, с двумя знаками после запятой
    }
    Console.WriteLine();
}

double Max(double[] arr) // метод (формула) новые данные и названия
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max) //условие проверяем
        {
            max=arr[i];
        }
    }
    return max;
}

double Min(double[] arr) // метод (формула) новые данные и названия
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min) //условие проверяем
        {
            min=arr[i];
        }
    }
    return min;
}

double[] array = CreateArray(5, 1, 3);//вывод массива на экран
double max =Max(array);
double min =Min(array);
PrintArray(array);
Console.WriteLine($" {(max-min):f2}");



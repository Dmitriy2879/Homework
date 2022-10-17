// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int len, int minLimit, int maxLimit) // создаем массив
{
    int[] array = new int[len]; // объявить массив
    Random rnd = new Random(); //генератор случайных чисел
    for (int i = 0; i < array.Length; i++) // условие
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1); //от мин до максим включительно
    }
    return array; //возвращаем массив
}

void PrintArray(int[] array) //вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t"); // массив в строчку
    }
    Console.WriteLine();
}

int Even(int[] arr) // метод (формула) новые данные и названия
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) // проверяем условие
        {
            res++;
        }
    }
    return res;
}

int[] myArray = CreateArray(6, 100, 999); //вывод массива на экран
PrintArray(myArray);
int Count = Even(myArray);
Console.WriteLine($"Количество четных чиcел в массиве: {Count}");

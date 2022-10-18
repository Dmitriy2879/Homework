// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int Odd(int[] arr) // метод (формула) новые данные и названия
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) //условие проверяем
        {
            sum = sum+arr[i];
        }
    }
    return sum;
}

int[] myArray = CreateArray(6, -3, 3); //вывод массива на экран
PrintArray(myArray);
int sum = Odd(myArray);
Console.WriteLine($"Сумма элементов на нечетных позициях : {sum}"); // результат

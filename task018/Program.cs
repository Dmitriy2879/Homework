// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] InputNumber(int vol)
{
    int length = vol;
    int[] num = new int[length];
    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine($"Введите число {i + 1}:  ");
        num[i] = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int VolumPlus(int[] res)
{
    int count = 0;
    for (int i = 0; i < res.Length; i++)
    {
        if (res[i] > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.Write("Сколько чисел ввести?:  ");
int vol = Convert.ToInt32(Console.ReadLine());

int[] res = InputNumber(vol);
int result = VolumPlus(res);

System.Console.WriteLine($"Количество чисел больше нуля: {result}");

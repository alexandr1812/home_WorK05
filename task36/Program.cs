// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.Write($"Введите количество элементов для создания массива: ");
int massElemtnts = Convert.ToInt32(Console.ReadLine());

int FillArray(int arrRandodElemenst, int min, int max)
{
    int[] randomNumbers = new int[arrRandodElemenst];
    int sum = 0;
    Console.Write("Рандомный массив: ");

    Random random = new Random();

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = random.Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
            sum = sum + randomNumbers[i];
        }
    }
    return sum;
}

int result = FillArray(massElemtnts, 1, 10);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, расположенных на нечетных позициях: {result}");
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных
Console.Clear();

int[] array = new int[10];

void FillArray (int[] arr, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int CountPositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( arr [i] % 2 == 1)
        {
            count++;
        }

    }
    return count;
}

FillArray(array, 100, 1000);
PrintArray(array);
int res = CountPositiveNumber(array);
Console.WriteLine($"четные цифры в массие -> {res}");
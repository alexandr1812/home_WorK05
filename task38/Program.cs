//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void MaxAndMinDifference()
{
    double[] arrayNumber = new double[10];
    Random random = new Random();
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        arrayNumber[i] = random.Next(1, 10);
        Console.Write(arrayNumber[i] + " ");
    }

    double maxElement = arrayNumber[0];
    double minElement = arrayNumber[0];

    for (int i = 1; i < arrayNumber.Length; i++)
    {
        if (maxElement < arrayNumber[i])
        {
            maxElement = arrayNumber[i];
        }
        if (minElement > arrayNumber[i])
        {
            minElement = arrayNumber[i];
        }
    }
    double result = maxElement - minElement;
    Console.WriteLine($"макисмальное -> ({maxElement}) минимальное -> ({minElement}) разница -> {result}");
}

MaxAndMinDifference();
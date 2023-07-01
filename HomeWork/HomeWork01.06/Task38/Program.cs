// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


void Main()
{
    double[] array = FillArray(5, 1, 10);
    PrintArray(array);

    double min = MinNumberArray(array);
    double max = MaxNumberArray(array);
    double difference = Math.Round((max - min), 3);

    System.Console.WriteLine($"Разница между мксимальным {max} и минимальным  {min} элементом массива равна {difference}");
}

double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
    }

    return tempArray;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


double MaxNumberArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }

    }
    return max;
}


double MinNumberArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }

    }
    return min;
}
//----------------------------------------------------

Main();
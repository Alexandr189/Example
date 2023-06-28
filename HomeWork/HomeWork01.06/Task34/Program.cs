// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] FillArray(int size, int leftRange, int rightRange )
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ",array) + "]");
}


int even(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even += 1;
        }
    }
    return even;
}

//----------------------------------------------------------------------------

int[] array = FillArray(5,100,999);
int numbereven = even(array);
PrintArray(array);
System.Console.WriteLine($"Колличество четных чисел : {numbereven}");
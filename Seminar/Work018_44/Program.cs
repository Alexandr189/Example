// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int[] Fibonach(int number)
{
    int[] array = new int[number];
    if (number == 1)
    {
        array[0] = 0;
    }
    else if (number == 2)
    {
        array[0] = 0;
        array[1] = 1;
    }
    else
    {
        array[0] = 0;
        array[1] = 1;
        for (int i = 2; i < number; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }
    }
    return array;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//--------------------------------------

int fibonacci = ReadInt("Введите колличество чисел фиббоначи: ");
PrintArray(Fibonach(fibonacci));
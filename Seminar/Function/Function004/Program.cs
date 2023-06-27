

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FilArray(int[] arr)
{
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }


}

void PrintArray(int[] arr)
{
    System.Console.WriteLine(string.Join(" ", arr));
}

// Функция ввода данных
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


//------------------------------------------------
int SizeArray = ReadInt("Введите размер массива: ");
int[] array = new int[SizeArray];
FilArray(array);
PrintArray(array);


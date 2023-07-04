void ReversArray(int[] array)
{
    int temp = 0;
    for(int i = 0; i<array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
}

//Array.Reverse(array); Вариант разворота при помощи встроенной функции
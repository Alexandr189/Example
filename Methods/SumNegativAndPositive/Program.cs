void FindSumNegativeAndPositive(int[] array, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumP += array[i]; // sumPositive = sumPositive + array[i]
        }
        else
        {
            sumN += array[i];
        }
    }
}

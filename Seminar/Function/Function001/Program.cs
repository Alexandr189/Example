

// Функции, знакомство:


int ReadInt(string text)
{
    System.Console.Write(text);
    // int tempnumber = Convert.ToInt32(Console.ReadLine());
    // return tempnumber;
    // Можно сократить, без применения переменных
    return Convert.ToInt32(Console.ReadLine());

}
// Функция подсчета чисел

int SumNumbers(int A)
{
    int sum = 0;
    for(int i = 1; i<=A; i++)
    {
        sum += i;
    }

    return sum;
}
//---------------------------------------------------------------------------------------

int number = ReadInt("Введите число: ");
int sum = SumNumbers(number);
 


System.Console.WriteLine($"Сумма чисел от 1 до {number}: {sum}");

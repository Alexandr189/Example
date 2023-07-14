// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
int M = ReadInt("Введите начальное число: ");
int N = ReadInt("Введите конечное число: ");
int sum = Summ(M,N);
System.Console.WriteLine($"Сумма натуральных чисел от числа {M} до {N} = {sum + M}");
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// вывод натуральных чисел в промежутке от M до N
void Numbers(int M, int N)
{
    if (N < M) return;
    System.Console.Write(M + " ");
    Numbers(M + 1, N);

}
int Summ(int M, int N)
{
    int sum = M;
        if (M == N) 
        return 0;
        else
        {
            M++;
            sum = M + Summ(M , N);
            return sum;
        }

}
//----------------------------------------------------------------

Main();
// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"



int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Numbers(int M, int N)
{
    if (N < M) return;
    System.Console.Write(M + " ");
    Numbers(M + 1, N);

}



int M = ReadInt("Введите первое число: ");
int N = ReadInt("Введите второе число: ");
if (M < N)
{
    Numbers(M, N);
}
else
{
    Numbers(N,M);
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



void Main()
{
int M = ReadInt("Введите  число M: ");
int N = ReadInt("Введите число N: ");
int akk = AkkerMan(M,N);
System.Console.WriteLine($"Функция Аккермана от чисел {M} и {N} равна {akk}");
}

int AkkerMan(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkerMan(m - 1, 1);
    }
    else
    {
        return (AkkerMan(m - 1, AkkerMan(m, n - 1)));
    }
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs (Convert.ToInt32(Console.ReadLine()));
}
//-----------------------------------------------
Main();


// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Result(int N)
{
    int factorial = 1;
    for (int i = 1; i<=N ; i++)
    {
        factorial *= i ;
    }
    return factorial;
}
//----------------------------------------------------------------



int number = ReadInt("Введите число: ");
if (number < 1)
{
    System.Console.WriteLine("Неверное число");
    return;
}
int result = Result(number);
System.Console.WriteLine($"Факториалом числа {number} является : {result}");
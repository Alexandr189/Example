

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3 -> 11
// 2 -> 10
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void NumberToBinare(int number)
{
    if (number == 0)
    {
        return;
    }
    NumberToBinare(number / 2);
    System.Console.Write(number % 2);
}

int a = ReadInt("Введите число для преобразования в двоичную систему: ");
// NumberToBinare(a);

// Конвертация в двоичную систему через строку
System.Console.WriteLine(Convert.ToString(a,2));


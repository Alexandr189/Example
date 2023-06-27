// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return  Convert.ToInt32(Console.ReadLine()); // или return Convert.ToInt32(Console.ReadLine());
   
}


int SumNumber(int number)
{
    int result = 0;

    while (number > 0)
    {
        result = result + number % 10;
        number /= 10;

    }
    return result;
    
}

//-------------------------------------------------


int number = ReadInt("Введите число: ");
int sum = SumNumber(number);
System.Console.WriteLine($"Сумма цифр числа : {number} равна -> {sum}");
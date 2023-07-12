// Задача 67: Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int X)
{
    if (X == 0) return 0; 
    return X % 10 + SumNumbers(X/10);

}
int X = ReadInt("Введите число: ");
int numbers = SumNumbers(X);
System.Console.WriteLine($"Сумма цифр в числе {X} = {numbers}");
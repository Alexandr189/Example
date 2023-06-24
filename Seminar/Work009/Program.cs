﻿//  Задача 24: Напишите программу, которая принимает на вход число (А)
//   и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int ReadInt(string text)
{
    System.Console.Write(text);
    int tempNumber = Convert.ToInt32(Console.ReadLine()); // или return Convert.ToInt32(Console.ReadLine());
    return tempNumber;
}

int SumNumbers(int A)
{
    int sum = 0;

    for(int i = 1; i<=A; i++)
    {
        sum += i;
    }

    return sum;
}



int number = ReadInt("Введите число: ");
int sum = SumNumbers(number);



System.Console.WriteLine($"Сумма чисел от 1 до {number} : {sum}");
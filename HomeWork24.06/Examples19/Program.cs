// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.WriteLine("Введите пятизначное число");
 string number = Console.ReadLine();
 int len = number.Length;

 if (len == 5)
 {
    if (number[0] == number[len - 1] && number[1] == number[len - 2])
    {
        System.Console.WriteLine($"{number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"{number} Не является палиндромом");
    }
 }
 else
 {
    System.Console.WriteLine($"Число {number} не пятизначное");
 }



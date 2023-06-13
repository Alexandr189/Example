// Задача 6: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
 int count = number;

while (count > 999)
{
    count = count / 10;
}
if (count>99)
{
   int three = count%10;
   System.Console.WriteLine($"Третья цифра числа {number} является {three}");
}
else System.Console.WriteLine( "Третьей цифры нет");

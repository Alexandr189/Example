// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


System.Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number2;

if (number1 > number2)
{
    max = number1;
    min = number2;
}

else
{
    max = number2;
    min = number1;
}

System.Console.Write("max= ");
System.Console.WriteLine(max);
System.Console.Write("min= ");
System.Console.WriteLine(min);


//  Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит 
//  остаток от деления.



System.Console.WriteLine("Напишите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Напишите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    System.Console.Write("Число кратное");
}

else System.Console.Write("Числа не кратные . Остаток от деления = " + number1 % number2);

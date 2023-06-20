// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.Write("Введите номер четверти : ");
int number = Convert.ToInt32(Console.ReadLine());

string[] array = { "X > 0 и Y > 0", "X < 0 и Y > 0", "X < 0 и Y < 0", "X > 0 и Y < 0" };

if (number>0 && number<5)

{
    System.Console.WriteLine(array[number-1]);
}


// if (number == 1)
// {
//     System.Console.WriteLine("X > 0 и Y > 0");
// }
// else if (number == 2)
// {
//     System.Console.WriteLine("X < 0 и Y > 0");
// }

// else if (number == 3)
// {
//     System.Console.WriteLine("X < 0 и Y < 0");
// }

// else if (number == 4)
// {
//     System.Console.WriteLine("X > 0 и Y < 0");
// }
else
{
    System.Console.WriteLine("Такой четверти не существует");
}

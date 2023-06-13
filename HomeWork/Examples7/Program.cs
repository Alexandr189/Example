// Задача 7: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.Write("Введите номер дня недели : ");
int day = Convert.ToInt32(Console.ReadLine());


if (day >= 1 && day <=7)
{
     if (day > 5)
    {
       System.Console.WriteLine("Сегодня выходной, поздравляю!");
    }
     else System.Console.WriteLine("Сегодня будний день, работать!! ,пока солнце светит");
}
else System.Console.WriteLine("Такого дня недели еще не придумали");
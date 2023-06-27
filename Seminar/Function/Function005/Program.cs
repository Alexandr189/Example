// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// озводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow(int A, int B)
{
    int i = 1;
    int number = A;
    while (i < B)
    {
        number *= A;
        i++;
    }
    return number;

}

//---------------------------------------------------------------------------


System.Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите степень числа: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sum = Pow(numberA, numberB);
System.Console.WriteLine(sum);


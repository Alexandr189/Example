// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


System.Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for(int i = 1; i<= number; i++)
{
    array[i-1]= (int) Math.Pow(i,3);
}

System.Console.WriteLine("[" + string.Join(", ", array)+ "]");
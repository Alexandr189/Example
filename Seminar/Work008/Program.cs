// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


System.Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for(int i = 1; i<= number; i++)
{
    array[i-1]= (int) Math.Pow(i,2);
}

System.Console.WriteLine("[" + string.Join(", ", array)+ "]");
// {
//      System.Console.Write(Math.Pow(i,2)+ " ");
// }


// int N = 1;
// while (N <= number)
// {
//  System.Console.Write(Math.Pow(N,2)+" ");
//  N++;
// }

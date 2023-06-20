
// double temp = Math.Sqrt(11);
// System.Console.WriteLine(temp);
// System.Console.WriteLine(Math.Round(temp, 3));




// Math.Pow(3,4); //Возведение числа 3 в степень 4
// Math.Sqrt(11); // Взятие квадратного корня
// Math.Round(temp, 3); // Округление

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int[] CoordinateA = new int[2];
System.Console.WriteLine("Введите X первой точки");
CoordinateA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите Y первой точки");
CoordinateA[1] = Convert.ToInt32(Console.ReadLine());

int[] CoordinateB = new int[2];
System.Console.WriteLine("Введите X первой точки");
CoordinateB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите Y первой точки");
CoordinateB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Round (Math.Sqrt(Math.Pow((CoordinateB[0] - CoordinateA[0]),2) + Math.Pow((CoordinateB[1]-CoordinateA[1]),2)),3));


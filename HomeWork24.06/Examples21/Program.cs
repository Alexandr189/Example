
// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int[] CoordinateA = new int[3];
System.Console.WriteLine("Введите координату X первой точки");
CoordinateA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y первой точки");
CoordinateA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Z первой точки");
CoordinateA[2] = Convert.ToInt32(Console.ReadLine());

int[] CoordinateB = new int[3];
System.Console.WriteLine("Введите координату X второй точки");
CoordinateB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y второй точки");
CoordinateB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Z второй точки");
CoordinateB[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine  (Math.Round(Math.Sqrt (Math.Pow((CoordinateB[0] - CoordinateA[0]),2) + Math.Pow((CoordinateB[1] - CoordinateA[1]),2) + Math.Pow ((CoordinateB[2] - CoordinateA[2]),2)),4));

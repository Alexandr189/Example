// string[,] table = new string[2, 5];
//String.Empty


// table[1, 2] = "слово";

// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         System.Console.WriteLine($"-{table[i,j]}-");

//     }
// }

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");

        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}



int[,] matrix = new int[3, 4];
PrintArray(matrix);

FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);

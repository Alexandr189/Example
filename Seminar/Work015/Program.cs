
// Random rand = new Random();
// double temp = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 3);
// System.Console.WriteLine(temp);


int number = ReadInt("Введите длину массива");
            int[] array1 = NewArray(number);
            int bufferNumber = number % 2 == 0 ? number / 2 : number / 2 + 1;
            int[] array2 = new int[bufferNumber];
            PrintArray(array1);
            Console.WriteLine();
           
            if (number % 2 == 0)
            {
                for (int i = 0, j = 0; i < number / 2; i++)
                {
                    array2[j] = array1[i] * array1[array1.Length - i - 1];
                    j++;
                }
            }else
            {
                for (int i = 0, j = 0; i < number / 2; i++)
                {
                    array2[j] = array1[i] * array1[array1.Length - i - 1];
                    j++;
                }
                array2[bufferNumber - 1] = array1[number/ 2];

            }
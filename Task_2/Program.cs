// Задайте массив на 10 целых чисел. 
//Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] array = { 8, 3, 2, 6, 4, 1, 5, 4, 6, 4 }; 
   
int[] array = new int[10]; 
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.WriteLine(array[i]);
}

   int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) res++;
            }
Console.WriteLine("\nКоличество четных чисел в этом массиве равно: " + res);

// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10]; //{ 29, 98, 99, 55, 73, 37, 33, 19, 95, 91};
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.WriteLine(array[i]);
}

int count = array.Count(x => x >= 20 && x <= 90);
Console.WriteLine($"{count} элемент(ов) массива находя(и)тся на отрезке [20, 90]");
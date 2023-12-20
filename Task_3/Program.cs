// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateArray(int size, int leftRange, int rightRange)
{
	double[] array = new double[size];
	Random rand = new Random();

	for (int i = 0; i < size; i++)
	{
		array[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3); // генерим целое + дробную и округляем до 3-х знаков
	}
	return array;
}

void PrintArray(double[] arrayForPrint)
{
	System.Console.Write("[ ");
	for (int i = 0; i < arrayForPrint.Length; i++)
	{
		System.Console.Write(arrayForPrint[i] + " ");
	}
	System.Console.Write("]");
	System.Console.WriteLine();
}

int ReadInt(string msg)
{
	Console.Write(msg);
	return Convert.ToInt32(Console.ReadLine());
}

int FindMinInArray(double[] array)
{
	int indexMin = 0;
	for(int i = 0; i < array.Length; i++ )
	{
		if(array[i] < array[indexMin])
			{
				indexMin = i;
			}
	}
	return indexMin;
}

int FindMaxInArray(double[] array)
{
	int indexMax = 0;
	for(int i = 0; i < array.Length; i++ )
	{
		if(array[i] > array[indexMax])
			{
				indexMax = i;
			}
	}
	return indexMax;
}

// --------------------------
int N = ReadInt("Введите размер массива: ");

double[] myArray = GenerateArray(N, 0, 9);
PrintArray(myArray);

int iMin = FindMinInArray(myArray);
int iMax = FindMaxInArray(myArray);

System.Console.WriteLine($"Разница между {myArray[iMin]} и {myArray[iMax]} равна: {myArray[iMax] - myArray[iMin]}");

// System.Console.WriteLine(myArray.Max() - myArray.Min());
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int[,] firstMartrix = { { 2, 4 }, { 3, 2 } };
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = { { 3, 4 }, { 3, 3 } }; ;
Console.WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);

//int[,] resultMatrix = new int[0, 0];


void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
	for (int i = 0; i < resultMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < resultMatrix.GetLength(1); j++)
		{
			int sum = 0;
			for (int k = 0; k < firstMartrix.GetLength(1); k++)
			{
				sum += firstMartrix[i, k] * secomdMartrix[k, j];
			}
			resultMatrix[i, j] = sum;
		}
	}
}


void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

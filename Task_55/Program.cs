﻿/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/


int[,] GenerateRandomMatrix(int min, int max, int m, int n)
{
	int[,] mtrx = new int[m, n];
	Random r = new Random();
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			mtrx[i, j] = r.Next(min, max + 1);
		}
	}
	return mtrx;
}

int[,] Transpose(int[,] mtrx)
{
	int m = mtrx.GetLength(0);
	int n = mtrx.GetLength(1);
	int[,] result = new int[n, m];
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			result[i, j] = mtrx[j, i];
		}
	}
	return result;
}

int[,] randMatrix = GenerateRandomMatrix(0, 9, 4, 6);
PrintMatrix(randMatrix);
PrintMatrix(Transpose(randMatrix));
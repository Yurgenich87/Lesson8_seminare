/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int a = 4;
int[,] spiralArray = new int[a, a];

int temp = 1;
int b = 0;
int c = 0;

while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
	spiralArray[b, c] = temp;
	temp++;
	if (b <= c + 1 && b + c < spiralArray.GetLength(1) - 1)
		c++;
	else if (b < c && b + c >= spiralArray.GetLength(0) - 1)
		b++;
	else if (b >= c && b + c > spiralArray.GetLength(1) - 1)
		c--;
	else
		b--;
}


void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (array[i, j] / 10 <= 0)
				Console.Write($" {array[i, j]} ");

			else Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}
}

PrintArray(spiralArray);

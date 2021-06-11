using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		//matrix declaration
		//int[,] matrix = new int[4,4]{{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}};
		int[,] matrix = new int[4, 3] { { 1, 2, 3 }, { 5, 6, 7 }, { 9, 10, 11 }, { 13, 14, 15 } };

		if (matrix.Length == 0)
		{
			Console.WriteLine("Please define Matrix ");

		}

		List<int> list = new List<int>();

		//matrix.GetLength(0) gives "Row length(First dimension size)" and matrix.GetLength(1) gives "column length(Second dimenstion size)"
		SpiralOrder(matrix, 0, 0, matrix.GetLength(0), matrix.GetLength(1), list);

		//Display the Spiral order
		foreach (int l in list)
			Console.Write(l + " ");
	}


	public static void SpiralOrder(int[,] matrix, int startRow, int startColumn, int endRow, int endColumn, List<int> accumulator)
	{

		if (startRow >= endRow || startColumn >= endColumn)
		{
			return;
		}

		if (startRow == endRow - 1 && endColumn - 1 == startColumn)
		{
			accumulator.Add(matrix[startRow, endRow - 1]);

		}
		else if (startRow == endRow - 1 && endColumn - 1 > startColumn)
		{
			while (startColumn < endColumn)
			{
				accumulator.Add(matrix[endRow - 1, startColumn++]);
			}
			return;
		}
		else if (endColumn - 1 == startColumn && endRow - 1 > startRow)
		{
			while (startRow < endRow)
			{
				accumulator.Add(matrix[startRow++, endColumn - 1]);
			}
			return;
		}

		// Adds first row of the matrix from 0 to Last but one element , to the Final array.
		for (int i = startColumn; i < endColumn - 1; i++)
		{
			accumulator.Add(matrix[startRow, i]);

		}

		// Adds Last column elements from top to (bottom-1) to the Final array.
		for (int i = startRow; i < endRow - 1; i++)
		{
			accumulator.Add(matrix[i, endColumn - 1]);
		}

		// Adds Last row elements from right to (extreme left-1) to the Final array.
		for (int i = endColumn - 1; i > startColumn; i--)
		{
			accumulator.Add(matrix[endRow - 1, i]);
		}

		// Adds First column elements from bottom to (top+1) to the Final array.
		for (int i = endRow - 1; i > startRow; i--)
		{
			accumulator.Add(matrix[i, startColumn]);
		}

		//Increment Start row and Start column by 1 and also decrement EndRow and End Column by 1 and the call the recursive function
		SpiralOrder(matrix, startRow + 1, startColumn + 1, endRow - 1, endColumn - 1, accumulator);

	}
}

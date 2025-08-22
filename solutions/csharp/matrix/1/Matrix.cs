using System;
using System.Collections.Generic;
using System.Linq;

public class Matrix
{
    private readonly int[][] matrix;

    public Matrix(string input) => matrix = ParseMatrix(input);

    private int[][] ParseMatrix(string input)
    {
        return input
            .Split('\n', StringSplitOptions.RemoveEmptyEntries)
            .Select(row => row.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray())
            .ToArray();
    }

    public int[] Row(int row) => matrix[row - 1];

    public int[] Column(int col) => Enumerable.Range(0, matrix.Length).Select(row => matrix[row][col - 1]).ToArray();
}

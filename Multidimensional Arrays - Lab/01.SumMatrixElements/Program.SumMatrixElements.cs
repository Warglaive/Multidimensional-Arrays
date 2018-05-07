using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rows = input[0];
            var cols = input[1];

            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                var elements = Console.ReadLine()
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                matrix[i] = new int[elements.Length];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = elements[j];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(cols);
            var result = 0;
            foreach (var currentArray in matrix)
            {
                result += currentArray.Sum();
            }
            Console.WriteLine(result);
        }
    }
}
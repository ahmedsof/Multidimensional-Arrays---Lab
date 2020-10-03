using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse).ToArray();

                matrix[row] = new int[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];

                }
            }

            string comand = Console.ReadLine();

            while (comand != "END")
            {
                var splited = comand.Split(" ");

                int row = int.Parse(splited[1]);
                int col = int.Parse(splited[2]);
                int value = int.Parse(splited[3]);
                bool isInvalid = false;

                if (matrix.Length <= row || row < 0)
                {
                    isInvalid = true;
                }

                else if (matrix[row].Length <= col || col < 0)
                {
                    isInvalid = true;
                }

                if (isInvalid)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {


                    if (splited[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }

                    if (splited[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }

                comand = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}

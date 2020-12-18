using System;
using System.Linq;

namespace P03_JediGalaxy
{
    public class Program
    {
        public static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimestions[0];
            int cols = dimestions[1];

            int[,] matrix = new int[rows, cols];

            int value = 0;
            InitializeMatrix(rows, cols, matrix, value);

            

            string command = Console.ReadLine();
            long sum = 0;

            while (command != "Let the Force be with you")
            {
                int[] playerStartPosition = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evilPowerCoordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int evilPowerRow = evilPowerCoordinates[0];
                int evilPowerCol = evilPowerCoordinates[1];

                while (evilPowerRow >= 0 && evilPowerCol >= 0)
                {
                    if (evilPowerRow >= 0 && evilPowerRow < matrix.GetLength(0) && evilPowerCol >= 0 && evilPowerCol < matrix.GetLength(1))
                    {
                        matrix[evilPowerRow, evilPowerCol] = 0;
                    }
                    evilPowerRow--;
                    evilPowerCol--;
                }

                int playerRow = playerStartPosition[0];
                int playerCol = playerStartPosition[1];

                while (playerRow >= 0 && playerCol < matrix.GetLength(1))
                {
                    if (playerRow >= 0 && playerRow < matrix.GetLength(0) && playerCol >= 0 && playerCol < matrix.GetLength(1))
                    {
                        sum += matrix[playerRow, playerCol];
                    }

                    playerCol++;
                    playerRow--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        private static void InitializeMatrix(int rows, int cols, int[,] matrix, int value)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = value++;
                }
            }
        }
    }
}

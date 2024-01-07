using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1v7
{
    using System;

    public class SecondPart
    {
        // Метод для генерации случайной матрицы
        public int[,] GenerateRandomMatrix(int rows, int cols)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(-10, 11); // Генерация чисел от -10 до 10
                }
            }

            return matrix;
        }

        // Метод для вывода матрицы
        public void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        // Метод для сортировки столбцов по характеристикам
        public void SortColumnsByCharacteristics(int[,] matrix)
        {
            int cols = matrix.GetLength(1);

            // Создаем массив, хранящий характеристики для каждого столбца
            int[] characteristics = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                characteristics[j] = CalculateColumnCharacteristic(matrix, j);
            }

            // Сортировка массива характеристик и одновременная перестановка столбцов матрицы
            for (int i = 0; i < cols - 1; i++)
            {
                for (int j = 0; j < cols - 1 - i; j++)
                {
                    if (characteristics[j] > characteristics[j + 1])
                    {
                        SwapColumns(matrix, j, j + 1);
                        Swap(ref characteristics[j], ref characteristics[j + 1]);
                    }
                }
            }
        }

        // Метод для вычисления характеристики столбца
        private int CalculateColumnCharacteristic(int[,] matrix, int column)
        {
            int rows = matrix.GetLength(0);
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                int element = matrix[i, column];
                if (element < 0 && element % 2 != 0)
                {
                    sum += Math.Abs(element);
                }
            }

            return sum;
        }

        // Метод для обмена местами двух столбцов матрицы
        private void SwapColumns(int[,] matrix, int col1, int col2)
        {
            int rows = matrix.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                Swap(ref matrix[i, col1], ref matrix[i, col2]);
            }
        }

        // Метод для обмена значений двух переменных
        private void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // Метод для нахождения суммы элементов в столбцах с отрицательными элементами
        public int SumColumnsWithNegatives(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                bool foundNegative = false;
                int columnSum = 0;

                for (int i = 0; i < rows; i++)
                {
                    columnSum += matrix[i, j];

                    if (matrix[i, j] < 0)
                    {
                        foundNegative = true;
                    }
                }

                if (foundNegative)
                {
                    sum += columnSum;
                }
            }

            return sum;
        }
    }

}

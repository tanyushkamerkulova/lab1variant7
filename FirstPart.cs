using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1v7
{
    public class FirstPart
    {
        public void PrintArray(double[] array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
        }

        public double[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = Math.Round(random.NextDouble() * 20 - 10, 2); // Генерация чисел от 0 до 10
            }

            return array;
        }

        // Метод для поиска номера минимального элемента массива
        public int MinIndex(double[] array)
        {
            double min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        // Метод для вычисления суммы элементов между первым и вторым отрицательными элементами
        public double Summa(double[] array)
        {
            int firstNegativeIndex = -1;
            int secondNegativeIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (firstNegativeIndex == -1)
                    {
                        firstNegativeIndex = i;
                    }
                    else
                    {
                        secondNegativeIndex = i;
                        break;
                    }
                }
            }

            if (firstNegativeIndex != -1 && secondNegativeIndex != -1)
            {
                double sum = 0;

                for (int i = firstNegativeIndex + 1; i < secondNegativeIndex; i++)
                {
                    sum += array[i];
                }

                return sum;
            }

            return 0;
        }

        // Метод для преобразования массива
        public void TransformArray(double[] array)
        {
            // Разделение массива на элементы <= 1 и элементы > 1
            double[] newArray = new double[array.Length];
            int newIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < 1)
                {
                    newArray[newIndex++] = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) >= 1)
                {
                    newArray[newIndex++] = array[i];
                }
            }

            // Копирование преобразованного массива в оригинальный
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = newArray[i];
            }
        }
    }
}

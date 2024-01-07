namespace lab1v7
{
    using System;

    class Program
    {
        static void Main()
        {
            // Введите размер массива
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());

            FirstPart firstPart = new FirstPart();

            double[] array = firstPart.GenerateRandomArray(N);

            firstPart.PrintArray(array);


            // Вычисление номера минимального элемента массива
            int minIndex = firstPart.MinIndex(array);
            Console.WriteLine($"Номер минимального элемента: {minIndex + 1}");

            // Вычисление суммы элементов между первым и вторым отрицательными элементами
            double sumBetweenNegatives = firstPart.Summa(array);
            Console.WriteLine($"Сумма элементов между первым и вторым отрицательными: {sumBetweenNegatives}");

            // Преобразование массива
            firstPart.TransformArray(array);

            // Вывод преобразованного массива
            Console.WriteLine("Преобразованный массив:");
            firstPart.PrintArray(array);

            Console.ReadLine();

            Console.WriteLine("ВТОРАЯ ЧАСТЬ ЛАБОРАТОРНОЙ РАБОТЫ");

            SecondPart secondPart = new SecondPart();

            // Введите размеры матрицы
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            // Инициализация и заполнение матрицы случайными значениями
            int[,] matrix = secondPart.GenerateRandomMatrix(rows, cols);

            // Вывод исходной матрицы
            Console.WriteLine("Исходная матрица:");
            secondPart.PrintMatrix(matrix);

            // Сортировка столбцов по характеристикам
            secondPart.SortColumnsByCharacteristics(matrix);

            // Вывод матрицы после сортировки
            Console.WriteLine("Матрица после сортировки столбцов:");
            secondPart.PrintMatrix(matrix);

            // Нахождение суммы элементов в столбцах с отрицательными элементами
            int sumNegativeColumns = secondPart.SumColumnsWithNegatives(matrix);
            Console.WriteLine($"Сумма элементов в столбцах с отрицательными элементами: {sumNegativeColumns}");

            Console.ReadLine();
        }
    }

}
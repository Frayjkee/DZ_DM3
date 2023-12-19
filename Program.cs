// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


using System;

class Program
{
    static void Main()
    {
        // Задаем размеры массива
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        // Создаем двумерный массив
        int[,] matrix = new int[rows, cols];

        // Заполняем массив случайными числами (можно заменить на ввод с клавиатуры)
        Random random = new Random();
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Находим строку с наименьшей суммой элементов
        int minSum = int.MaxValue;
        int minSumRow = -1;

        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < cols; j++)
            {
                currentSum += matrix[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRow = i;
            }
        }

        // Выводим результат
        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRow + 1}");
        Console.WriteLine($"Сумма элементов этой строки: {minSum}");

        Console.ReadLine(); // Чтобы консольное окно не закрылось сразу
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Helpers
{
    static class IOHelper
    {
        static Random random = new Random();

        public static int SaveInput(int min_value, int max_value, string message)
        {
            int result = 0;
            Console.WriteLine($"Введите число в диапазоне от {min_value} до {max_value}.");

            int.TryParse(Console.ReadLine(), out int reuslt);

            if (result > min_value && result < max_value) return result;
            else throw new ArgumentException(message);
        }

        public static double SaveInput(double min_value, double max_value, string message)
        {
            double result = 0;
            Console.WriteLine($"Введите число в диапазоне от {min_value} до {max_value}.");

            double.TryParse(Console.ReadLine(), out double reuslt);

            if (result > min_value && result < max_value) return result;
            else throw new ArgumentException(message);
        }

        public static (double, double) InputPoint(string message)
        {
            Console.WriteLine(message);

            double.TryParse(Console.ReadLine(), out double reuslt1);
            double.TryParse(Console.ReadLine(), out double reuslt2);

            return (reuslt1, reuslt2);
        }

        public static void Line(int lengh)
        {
            for (int i = 0; i < lengh; i++)
            {
                Console.Write("-");
            }
        }

        public static int TextMenu(string[] menu_items)
        {
            return 0; //TODO
        }

        public static int[] GenerateIntArray(int size, int min, int max)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }

        public static double[] GenerateDoubleArray(int size, double min, double max)
        {
            double[] array = new double[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * (max - min) + min;
            }
            return array;
        }

        public static int[,] GenerateIntMatrix(int rows, int cols, int min, int max)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(min, max + 1);
                }
            }
            return matrix;
        }

        public static double[,] GenerateDoubleMatrix(int rows, int cols, int min, int max)
        {
            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.NextDouble() * (max - min) + min;
                }
            }
            return matrix;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }

        public static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}

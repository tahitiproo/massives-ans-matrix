using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Homework
{
    class TumakovLaba
    {
        static int Schet(char[] text, char[] letter)
        {
            int Count = 0;

            foreach (char i in text)
                foreach (char j in letter)
                    if (i == j)
                        Count++;

            return Count;
        }

        static void PlesuareAttention(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void MatrixMultiplication(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                Console.WriteLine("Данные матрицы нельзя перемножить");
            }
            else
            {
                int[,] r = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix2.GetLength(0); k++)
                        {
                            r[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
                Console.WriteLine("Произведение матриц: ");
                PlesuareAttention(r);
            }
        }

        static void AverageTemperature(double[,] temperature)
        {
            double sum = 0;
            double sr_arif = 1;
            double[] srednMas = new double[12];

            for (int i = 0; i < temperature.GetLength(0); i++)
            {

                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    sum += temperature[i, j];
                    sr_arif = Math.Round(sum / 30, 2);
                }
                srednMas[i] = sr_arif;
                Console.WriteLine($"Средняя температура в {i + 1} месяце - {sr_arif}");
            }
            Array.Sort(srednMas);
            Console.WriteLine("Средние значения температур в месяцах по возрастанию: ");
            foreach (double i in srednMas)
                Console.Write(i + " ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков 6.1");
            string readText = File.ReadAllText(@"C:\Users\Username\source\repos\DZ\DZ\filename.txt");
            char[] array = readText.ToLower().ToCharArray();
            char[] vowels = "АЕЁИОУЫЭЮЯ".ToLower().ToCharArray();
            char[] consonants = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩЬЪ".ToLower().ToCharArray();
            Console.WriteLine($"Гласных в файле: {Schet(array, vowels)}");
            Console.WriteLine($"Согласных в файле: {Schet(array, consonants)}");
            Console.WriteLine();


            Console.WriteLine("Тумаков 6.2");
            Random random = new Random();
            byte m = (byte)random.Next(1, 3);
            byte n = (byte)random.Next(1, 3);
            byte q = (byte)random.Next(1, 3);
            int[,] A = new int[n, m];
            int[,] B = new int[q, n];
            Console.WriteLine("Заполните 1 матрицу");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Заполните 2 матрицу");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}] = ", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Первая матрица:");
            PlesuareAttention(A);
            Console.WriteLine("Вторая матрица:");
            PlesuareAttention(B);
            MatrixMultiplication(A, B);
            Console.WriteLine();

            Console.WriteLine("Тумаков дз 6.1");
            Random rand = new Random();
            double[,] temperature = new double[12, 30];
            for (int j = 0; j < 30; j++)
                for (int i = 0; i < 12; i++)
                    temperature[i, j] = rand.Next(-30, 30);
            AverageTemperature(temperature);
            Console.WriteLine();
        }
    }
}
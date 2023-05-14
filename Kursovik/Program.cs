using System;
using System.Text;
using System.IO;

namespace Kursovik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fileName = @"C:\Users\hsoff\OneDrive\Рабочий стол\note.txt";

            string text = File.ReadAllText(fileName);     
            var array = text.Split(';').Select(int.Parse).ToArray();
        Found:
            try
            {
                Console.WriteLine("Решение СЛАУ методом Гаусса");
                Console.WriteLine();
                
                Console.WriteLine("Для запуска программы введите 'Запуск'.");
                Console.WriteLine("Для выхода из программы введите 'Выход'.");
                Console.WriteLine("Примечание! Ввод чувствителен к регистру введнных символов.");
                Console.WriteLine();
                string Control;
                Control = Console.ReadLine();
                while (true)
                {
                    if (Control == "Запуск")
                    {
                        Console.WriteLine();
                        Console.Write("Введите размерность матрицы (от 2 до 5): ");
                        int RowAm = int.Parse(Console.ReadLine());
                        if (RowAm > 5 || RowAm < 2)
                        {
                            Console.WriteLine("Некорректный ввод.");
                            goto Found;
                        }
                        if (RowAm == 3)
                        {
                            double[,] MatrixCoef = new double[RowAm, RowAm];
                            double[] FreeCoef = new double[RowAm];
                            double Multi1, Multi2;
                            double[] Result = new double[RowAm];
                            Console.WriteLine();
                            Console.WriteLine("Введите коэффициенты и свободные члены матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                for (int j = 0; j < RowAm; j++)
                                {
                                    int x1 = 2;
                                    int x2 = 4;
                                    int x = 0;
                                    if (i == 1)
                                    {

                                        x = i + j + x1;
                                    }
                                    else
                                    if (i == 2)
                                    {

                                        x = i + j + x2;
                                    }
                                    else
                                    {
                                        x = i + j;
                                    }
                                    Console.Write($"A[{i + 1}][{j + 1}] = ");
                                    MatrixCoef[i, j] = array[x];
                                    Console.Write(array[x] + "; ");
                                }
                                Console.Write($"B[{i + 1}] = ");
                                FreeCoef[i] = double.Parse(Console.ReadLine());
                                Console.WriteLine();
                            }
                            Console.WriteLine("Начальный вид матрицы:");
                            Console.WriteLine();
                            int MatrixRow = MatrixCoef.GetLength(0);
                            int MatrixCol = MatrixCoef.GetLength(1);
                            for (int i = 0; i < MatrixRow; i++)
                            {
                                for (int j = 0; j < MatrixCol; j++)
                                {
                                    Console.Write(Math.Round(MatrixCoef[i, j], 3) + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine("Свободные члены матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                Console.WriteLine($"B[{i + 1}] = {FreeCoef[i]}");
                            }
                            Console.WriteLine();
                            for (int k = 0; k < RowAm; k++)
                            {
                                for (int j = k + 1; j < RowAm; j++)
                                {
                                    Multi1 = MatrixCoef[j, k] / MatrixCoef[k, k];
                                    for (int i = k; i < RowAm; i++)
                                    {
                                        MatrixCoef[j, i] = MatrixCoef[j, i] - Multi1 * MatrixCoef[k, i];
                                    }
                                    FreeCoef[j] = FreeCoef[j] - Multi1 * FreeCoef[k];
                                }
                            }
                            for (int k = RowAm - 1; k >= 0; k--)
                            {
                                Multi1 = 0;
                                for (int j = k; j < RowAm; j++)
                                {
                                    Multi2 = MatrixCoef[k, j] * Result[j];
                                    Multi1 += Multi2;
                                }
                                Result[k] = (FreeCoef[k] - Multi1) / MatrixCoef[k, k];
                            }
                            Console.WriteLine("Конечный вид матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < MatrixRow; i++)
                            {
                                for (int j = 0; j < MatrixCol; j++)
                                {
                                    Console.Write(Math.Round(MatrixCoef[i, j], 3) + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine("Корни матрицы: ");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                Console.WriteLine($"X[{i + 1}] = {Math.Round(Result[i], 3)}");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Программа завершила решение.");
                            Console.WriteLine();
                            Console.WriteLine("Для повторного запуска программы введите 'Запуск'.");
                            Console.WriteLine("Для выхода из программы введите 'Выход'.");
                            Console.WriteLine();
                            Control = Console.ReadLine();
                        }
                        else
                        if (RowAm == 2)
                        {
                            double[,] MatrixCoef = new double[RowAm, RowAm];
                            double[] FreeCoef = new double[RowAm];
                            double Multi1, Multi2;
                            double[] Result = new double[RowAm];
                            Console.WriteLine();
                            Console.WriteLine("Введите коэффициенты и свободные члены матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                for (int j = 0; j < RowAm; j++)
                                {
                                    int x1 = 1;
                                    int x2 = 3;
                                    int x = 0;
                                    if (i == 1)
                                    {

                                        x = i + j + x1;
                                    }
                                    else
                                    if (i == 2)
                                    {

                                        x = i + j + x2;
                                    }
                                    else
                                    {
                                        x = i + j;
                                    }
                                    Console.Write($"A[{i + 1}][{j + 1}] = ");
                                    MatrixCoef[i, j] = array[x];
                                }
                                Console.Write($"B[{i + 1}] = ");
                                FreeCoef[i] = double.Parse(Console.ReadLine());
                                Console.WriteLine();
                            }
                            Console.WriteLine("Начальный вид матрицы:");
                            Console.WriteLine();
                            int MatrixRow = MatrixCoef.GetLength(0);
                            int MatrixCol = MatrixCoef.GetLength(1);
                            for (int i = 0; i < MatrixRow; i++)
                            {
                                for (int j = 0; j < MatrixCol; j++)
                                {
                                    Console.Write(Math.Round(MatrixCoef[i, j], 3) + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine("Свободные члены матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                Console.WriteLine($"B[{i + 1}] = {FreeCoef[i]}");
                            }
                            Console.WriteLine();
                            for (int k = 0; k < RowAm; k++)
                            {
                                for (int j = k + 1; j < RowAm; j++)
                                {
                                    Multi1 = MatrixCoef[j, k] / MatrixCoef[k, k];
                                    for (int i = k; i < RowAm; i++)
                                    {
                                        MatrixCoef[j, i] = MatrixCoef[j, i] - Multi1 * MatrixCoef[k, i];
                                    }
                                    FreeCoef[j] = FreeCoef[j] - Multi1 * FreeCoef[k];
                                }
                            }
                            for (int k = RowAm - 1; k >= 0; k--)
                            {
                                Multi1 = 0;
                                for (int j = k; j < RowAm; j++)
                                {
                                    Multi2 = MatrixCoef[k, j] * Result[j];
                                    Multi1 += Multi2;
                                }
                                Result[k] = (FreeCoef[k] - Multi1) / MatrixCoef[k, k];
                            }
                            Console.WriteLine("Конечный вид матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < MatrixRow; i++)
                            {
                                for (int j = 0; j < MatrixCol; j++)
                                {
                                    Console.Write(Math.Round(MatrixCoef[i, j], 3) + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine("Корни матрицы: ");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                Console.WriteLine($"X[{i + 1}] = {Math.Round(Result[i], 3)}");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Программа завершила решение.");
                            Console.WriteLine();
                            Console.WriteLine("Для повторного запуска программы введите 'Запуск'.");
                            Console.WriteLine("Для выхода из программы введите 'Выход'.");
                            Console.WriteLine();
                            Control = Console.ReadLine();
                        }
                        else
                        if (RowAm == 4)
                        {
                            double[,] MatrixCoef = new double[RowAm, RowAm];
                            double[] FreeCoef = new double[RowAm];
                            double Multi1, Multi2;
                            double[] Result = new double[RowAm];
                            Console.WriteLine();
                            Console.WriteLine("Введите коэффициенты и свободные члены матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                for (int j = 0; j < RowAm; j++)
                                {
                                    int x1 = 3;
                                    int x2 = 6;
                                    int x3 = 9;
                                    int x = 0;
                                    if (i == 1)
                                    {

                                        x = i + j + x1;
                                    }
                                    else
                                    if (i == 2)
                                    {

                                        x = i + j + x2;
                                    }
                                    else
                                    if(i == 3)
                                    {
                                        x = i + j + x3;
                                    }
                                    else
                                    {
                                        x = i + j;
                                    }
                                    Console.Write($"A[{i + 1}][{j + 1}] = ");
                                    MatrixCoef[i, j] = array[x];
                                }
                                Console.Write($"B[{i + 1}] = ");
                                FreeCoef[i] = double.Parse(Console.ReadLine());
                                Console.WriteLine();
                            }
                            Console.WriteLine("Начальный вид матрицы:");
                            Console.WriteLine();
                            int MatrixRow = MatrixCoef.GetLength(0);
                            int MatrixCol = MatrixCoef.GetLength(1);
                            for (int i = 0; i < MatrixRow; i++)
                            {
                                for (int j = 0; j < MatrixCol; j++)
                                {
                                    Console.Write(Math.Round(MatrixCoef[i, j], 3) + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine("Свободные члены матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                Console.WriteLine($"B[{i + 1}] = {FreeCoef[i]}");
                            }
                            Console.WriteLine();
                            for (int k = 0; k < RowAm; k++)
                            {
                                for (int j = k + 1; j < RowAm; j++)
                                {
                                    Multi1 = MatrixCoef[j, k] / MatrixCoef[k, k];
                                    for (int i = k; i < RowAm; i++)
                                    {
                                        MatrixCoef[j, i] = MatrixCoef[j, i] - Multi1 * MatrixCoef[k, i];
                                    }
                                    FreeCoef[j] = FreeCoef[j] - Multi1 * FreeCoef[k];
                                }
                            }
                            for (int k = RowAm - 1; k >= 0; k--)
                            {
                                Multi1 = 0;
                                for (int j = k; j < RowAm; j++)
                                {
                                    Multi2 = MatrixCoef[k, j] * Result[j];
                                    Multi1 += Multi2;
                                }
                                Result[k] = (FreeCoef[k] - Multi1) / MatrixCoef[k, k];
                            }
                            Console.WriteLine("Конечный вид матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < MatrixRow; i++)
                            {
                                for (int j = 0; j < MatrixCol; j++)
                                {
                                    Console.Write(Math.Round(MatrixCoef[i, j], 3) + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine("Корни матрицы: ");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                Console.WriteLine($"X[{i + 1}] = {Math.Round(Result[i], 3)}");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Программа завершила решение.");
                            Console.WriteLine();
                            Console.WriteLine("Для повторного запуска программы введите 'Запуск'.");
                            Console.WriteLine("Для выхода из программы введите 'Выход'.");
                            Console.WriteLine();
                            Control = Console.ReadLine();
                        }
                        else
                        if (RowAm == 5)
                        {
                            double[,] MatrixCoef = new double[RowAm, RowAm];
                            double[] FreeCoef = new double[RowAm];
                            double Multi1, Multi2;
                            double[] Result = new double[RowAm];
                            Console.WriteLine();
                            Console.WriteLine("Введите коэффициенты и свободные члены матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                for (int j = 0; j < RowAm; j++)
                                {
                                    int x1 = 4;
                                    int x2 = 8;
                                    int x3 = 12;
                                    int x4 = 16;
                                    int x = 0;
                                    if (i == 1)
                                    {

                                        x = i + j + x1;
                                    }
                                    else
                                    if (i == 2)
                                    {

                                        x = i + j + x2;
                                    }
                                    else
                                    if (i == 3)
                                    {
                                        x = i + j + x3;
                                    }
                                    else
                                    if (i == 4)
                                    {
                                        x = i + j + x4;
                                    }
                                    else
                                    {
                                        x = i + j;
                                    }
                                    Console.Write($"A[{i + 1}][{j + 1}] = ");
                                    MatrixCoef[i, j] = array[x];
                                }
                                Console.Write($"B[{i + 1}] = ");
                                FreeCoef[i] = double.Parse(Console.ReadLine());
                                Console.WriteLine();
                            }
                            Console.WriteLine("Начальный вид матрицы:");
                            Console.WriteLine();
                            int MatrixRow = MatrixCoef.GetLength(0);
                            int MatrixCol = MatrixCoef.GetLength(1);
                            for (int i = 0; i < MatrixRow; i++)
                            {
                                for (int j = 0; j < MatrixCol; j++)
                                {
                                    Console.Write(Math.Round(MatrixCoef[i, j], 3) + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine("Свободные члены матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                Console.WriteLine($"B[{i + 1}] = {FreeCoef[i]}");
                            }
                            Console.WriteLine();
                            for (int k = 0; k < RowAm; k++)
                            {
                                for (int j = k + 1; j < RowAm; j++)
                                {
                                    Multi1 = MatrixCoef[j, k] / MatrixCoef[k, k];
                                    for (int i = k; i < RowAm; i++)
                                    {
                                        MatrixCoef[j, i] = MatrixCoef[j, i] - Multi1 * MatrixCoef[k, i];
                                    }
                                    FreeCoef[j] = FreeCoef[j] - Multi1 * FreeCoef[k];
                                }
                            }
                            for (int k = RowAm - 1; k >= 0; k--)
                            {
                                Multi1 = 0;
                                for (int j = k; j < RowAm; j++)
                                {
                                    Multi2 = MatrixCoef[k, j] * Result[j];
                                    Multi1 += Multi2;
                                }
                                Result[k] = (FreeCoef[k] - Multi1) / MatrixCoef[k, k];
                            }
                            Console.WriteLine("Конечный вид матрицы:");
                            Console.WriteLine();
                            for (int i = 0; i < MatrixRow; i++)
                            {
                                for (int j = 0; j < MatrixCol; j++)
                                {
                                    Console.Write(Math.Round(MatrixCoef[i, j],3) + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine("Корни матрицы: ");
                            Console.WriteLine();
                            for (int i = 0; i < RowAm; i++)
                            {
                                Console.WriteLine($"X[{i + 1}] = {Math.Round(Result[i], 3)}");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Программа завершила решение.");
                            Console.WriteLine();
                            Console.WriteLine("Для повторного запуска программы введите 'Запуск'.");
                            Console.WriteLine("Для выхода из программы введите 'Выход'.");
                            Console.WriteLine();
                            Control = Console.ReadLine();
                        }

                        if (Control == "Выход")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Программа завершила работу.");
                            Thread.Sleep(1000);
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ошибка! Ввод недопустимого значения.");
                            Console.WriteLine();
                            Control = Console.ReadLine();
                        }
                    }
                        
                }
            } catch 
            {
                Console.WriteLine("Неправильный ввод значения");
                goto Found;
            }
            
        }
    }
}
//svg does precious
using System;                          // Аналог <iostream> для работы с консолью и основными функциями
using System.Collections.Generic;       // Аналог <vector>, <list>, <map>, <set>, <unordered_map>, <unordered_set>, <stack>, <queue>
using System.Text;                      // Аналог <string>, <cstring> (для работы со строками и StringBuilder)
using System.Linq;                      // Аналог <algorithm> (для работы с LINQ, сортировок, поиска и т.д.)
using System.IO;                        // Аналог <cstdio>, <fstream> (работа с файлами)
using System.Globalization;             // Аналог <iomanip> (для форматирования)
using System.Collections;               // Работа с различными коллекциями (например, ArrayList)
using System.Threading;                 // Потоки и многопоточность
using System.Runtime.Serialization;     // Аналог <stdexcept> (работа с исключениями)
using System.Reflection;                // Аналог <typeinfo> (информация о типах, рефлексия)
using System.Diagnostics;               // Аналог <utility>, <std::pair> (вспомогательные функции и классы)
using System.ComponentModel;            // Дополнительные утилиты и атрибуты
using System.Numerics;                  // Работа с большими числами и математическими операциями
using System.Globalization;
using System.Diagnostics;
using System.Net;
using System.Numerics;
// Для работы с потоками данных:
using System.Threading.Tasks;           // Асинхронные задачи

// Для работы с датами и временем:
using System.Timers;                    // Для работы с таймерами и временем
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO; //important
using System.Globalization;
using System.Collections;
using System.Threading;
using System.Runtime.Serialization;
using System.Reflection;
using System.Diagnostics;
using System.ComponentModel;
using System.Numerics;
using System.Globalization;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Web;
using System.Media;
using System.Drawing;
using System.Configuration;
using System.Timers;
using System.Runtime.Remoting;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Runtime;
using System.Windows;
using System.Windows.Input;
using System.Security.Principal;
using System.Security.Permissions;
using System.Resources;
using C = System.Console; //console
using dl = System.Decimal;//decimal
using str = System.String;//string
using l = System.Int64;   //long
using u = System.UInt64;  //Ulong
using db = System.Double; //Double

/*
Izzspot - 19 years
Boogie B - 20 years
SJ - 21 years
Bandokay - life sentence

Youngest in the charge 
OFB, we don't window shop
Bro caught him an opp and tried turn him off (Bow, bow)
In this X3, man's swervin' off (Skrr, skrr)
Free Boogie Bando, he got birded off (Free my bro, free my bro)
Whenever we get a burner loss
We just cop a next one and go burst it off (Ay)
Lil bro's tellin' me he got his earnings wrong
We just took him OT, now his trapline's gone (Ring, ring)
Hashtag 
Bro backed this ting and just started squeezin' (Clarted)
When it broad day, it was freezin'
Hashtag fuckery, hashtag screamin'
One on the hand ting woi, left man lеanin', leanin' (Fucker)
Show us cause it's good to feel it
Shortiе's cooze and she must be dreamin'
*/
/* ¡Adelante Barcelona, adelante Cataluña! Visca el Barça! Visca Catalunya!
   ¡Al diablo con todos los demás, porque lo más importante en la vida es el fútbol!
*/
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------
//hard one




class Program
{//Лабораторная работа 4
 //1,25 - Уровень 1 Задание 25; 1,26 - Уровень 1 Задание 26;
 //1,27 - Уровень 1 Задание 27; 2,7 - Уровень 2 Задание 7;
 //2,8 - Уровень 2 Задание 8; 2,9 - Уровень 2 Задание 9;
 //3,11 - Уровень 3 Задание 11; 3,12 - Уровень 3 Задание 12;
 //3,13 - Уровень 3 Задание 13

    static void Main()
    {
        // УРОВЕНЬ 1
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random rand = new Random();

        Console.Write("Введите номер уровня (1,25 , 2,8 ...): ");
        double checker = Convert.ToDouble(Console.ReadLine());

        if (checker == 1.25)
        {
            // Задание 25
            Console.WriteLine("Задание 1.25: Матрица X\n");
            Console.Write("Введите количество строк матрицы X:  \n");
            int rowsX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы X: \n");
            int colsX = Convert.ToInt32(Console.ReadLine());
            int[,] X = new int[rowsX, colsX];

            FillMatrix(X, rand);
            Console.WriteLine("Исходная матрица X:\n");
            PrintMatrix(X);

            // Локальная функция для обмена строками с макс и мин отрицательными элементами
            void SwapRowsWithMinMaxNegative(int[,] matrix)
            {
                int minNegativesRow = -1;
                int maxNegativesRow = -1;
                int minNegatives = int.MaxValue, maxNegatives = int.MinValue;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int negativesCount = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] < 0) negativesCount++;
                    }

                    if (negativesCount < minNegatives)
                    {
                        minNegatives = negativesCount;
                        minNegativesRow = i;
                    }

                    if (negativesCount > maxNegatives)
                    {
                        maxNegatives = negativesCount;
                        maxNegativesRow = i;
                    }
                }

                if (minNegativesRow != -1 && maxNegativesRow != -1 && minNegativesRow != maxNegativesRow)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int temp = matrix[minNegativesRow, j];
                        matrix[minNegativesRow, j] = matrix[maxNegativesRow, j];
                        matrix[maxNegativesRow, j] = temp;
                    }
                    Console.WriteLine("\nМатрица X после замены строк с мин и макс отрицательных элементов:\n");
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Замена строк не требуется.");
                }
            }

            SwapRowsWithMinMaxNegative(X);
        }
        else if (checker == 1.26)
        {
            // Задание 26
            Console.WriteLine("\nЗадание 1.26: Матрица A\n");
            Console.Write("Введите количество строк матрицы A: \n");
            int rowsA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы A: \n");
            int colsA = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[rowsA, colsA];

            FillMatrix(A, rand);
            Console.WriteLine("Исходная матрица A:\n");
            PrintMatrix(A);

            int[] B = new int[colsA];
            Console.WriteLine("Введите элементы вектора B(вводить новое число в каждой строке):");
            for (int i = 0; i < colsA; i++)
            {
                B[i] = Convert.ToInt32(Console.ReadLine());
            }

            void ReplaceRowWithMaxInColumn(int[,] matrix, int columnIndex, int[] vector)
            {
                // Проверка, достаточно ли столбцов для выполнения операции
                if (columnIndex >= matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: В матрице недостаточно столбцов для работы с индексом {columnIndex + 1}.");
                    return;
                }

                int maxRowIndex = 0;
                int maxValue = int.MinValue;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, columnIndex] > maxValue)
                    {
                        maxValue = matrix[i, columnIndex];
                        maxRowIndex = i;
                    }
                }

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[maxRowIndex, j] = vector[j];
                }

                Console.WriteLine("\nМатрица A после замены строки вектора B:\n");
                PrintMatrix(matrix);
            }

            // Проверка, достаточно ли столбцов для использования индекса 5
            ReplaceRowWithMaxInColumn(A, 5, B);
        }

        else if (checker == 1.27)
        {
            // Задание 27
            Console.WriteLine("\nЗадание 1.27: Матрица B\n");
            Console.Write("Введите количество строк матрицы B: \n");
            int rowsB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы B: \n");
            int colsB = Convert.ToInt32(Console.ReadLine());
            int[,] BMatrix = new int[rowsB, colsB];

            FillMatrix(BMatrix, rand);
            Console.WriteLine("Исходная матрица B:\n");
            PrintMatrix(BMatrix);

            void ReplaceColumnWithMaxElementsInReverse(int[,] matrix, int columnIndex)
            {
                int[] maxElements = new int[matrix.GetLength(0)];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    maxElements[i] = matrix[i, 0];
                    for (int j = 1; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > maxElements[i])
                        {
                            maxElements[i] = matrix[i, j];
                        }
                    }
                }

                Array.Reverse(maxElements);

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, columnIndex] = maxElements[i];
                }

                Console.WriteLine("\nМатрица B после замены 4-го столбца:\n");
                PrintMatrix(matrix);
            }
            // первый элемент в 4столбце заменяется на максимальный элемент последней строки(5),
            // второй элемент в 4столбце заменяется на максимальный элемент предпоследней строки(4) и тд
            ReplaceColumnWithMaxElementsInReverse(BMatrix, 3);
        }
        //
        //
        //
        //
        //
        //
        //
        //
        //
        // УРОВЕНЬ 2

        else if (checker == 2.7)
        {
            // Задание 7: Найти максимальный элемент на главной диагонали и заменить нулями элементы правее диагонали выше строки с этим элементом
            Console.WriteLine("\nЗадание 2.7: Матрица A (размер 6x6)");
            int size = 6;
            int[,] A = new int[size, size];

            FillMatrix(A, rand);
            Console.WriteLine("Исходная матрица A:\n");
            PrintMatrix(A);

            void ReplaceElementsAboveRowWithMaxOnDiagonal(int[,] matrix)
            {
                int maxDiagonalValue = int.MinValue;
                int maxDiagonalRow = 0;

                // Находим максимальный элемент на главной диагонали и его строку
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, i] > maxDiagonalValue)
                    {
                        maxDiagonalValue = matrix[i, i];
                        maxDiagonalRow = i;
                    }
                }

                // Заменяем элементы правее главной диагонали нулями выше строки с максимальным элементом на диагонали
                for (int i = 0; i < maxDiagonalRow; i++)
                {
                    for (int j = i + 1; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = 0;
                    }
                }

                Console.WriteLine("\nМатрица A после замены элементов правее диагонали выше строки с макс. диагональным элементом:\n");
                PrintMatrix(matrix);
            }

            ReplaceElementsAboveRowWithMaxOnDiagonal(A);
        }


        else if (checker == 2.8)
        {
            // Задание 8: Поменять местами максимальные элементы 1-й и 2-й строк, 3-й и 4-й, 5-й и 6-й строк
            Console.WriteLine("\nЗадание 2.8: Матрица B (размер 6x6)");
            int size = 6;
            int[,] B = new int[size, size];

            FillMatrix(B, rand);
            Console.WriteLine("Исходная матрица B:\n");
            PrintMatrix(B);

            void SwapMaxElementsInPairs(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i += 2)
                {
                    int maxIndex1 = 0;
                    int maxIndex2 = 0;
                    int max1 = matrix[i, 0];
                    int max2 = matrix[i + 1, 0];

                    // Поиск максимальных элементов в каждой паре строк
                    for (int j = 1; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > max1)
                        {
                            max1 = matrix[i, j];
                            maxIndex1 = j;
                        }
                        if (matrix[i + 1, j] > max2)
                        {
                            max2 = matrix[i + 1, j];
                            maxIndex2 = j;
                        }
                    }

                    // Замена максимальных элементов между строками
                    int temp = matrix[i, maxIndex1];
                    matrix[i, maxIndex1] = matrix[i + 1, maxIndex2];
                    matrix[i + 1, maxIndex2] = temp;
                }

                Console.WriteLine("\nМатрица B после замены максимальных элементов пар строк:\n");
                PrintMatrix(matrix);
            }

            SwapMaxElementsInPairs(B);
        }

        else if (checker == 2.9)
        {
            // Задание 9: Расположить элементы строк матрицы A (размер 6x7) в обратном порядке
            Console.WriteLine("\nЗадание 2.9: Матрица A (размер 6x7)");
            int rows = 6;
            int cols = 7;
            int[,] A = new int[rows, cols];

            FillMatrix(A, rand);
            Console.WriteLine("Исходная матрица A:\n");
            PrintMatrix(A);

            void ReverseElementsInRows(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int left = 0;
                    int right = matrix.GetLength(1) - 1;

                    // Переворачиваем элементы в строке
                    while (left < right)
                    {
                        int temp = matrix[i, left];
                        matrix[i, left] = matrix[i, right];
                        matrix[i, right] = temp;
                        left++;
                        right--;
                    }
                }

                Console.WriteLine("\nМатрица A после разворота элементов строк:\n");
                PrintMatrix(matrix);
            }

            ReverseElementsInRows(A);
        }
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        // УРОВЕНЬ 3

        if (checker == 3.11)
        {
            // Задание 11: Удалить все строки, содержащие нулевые элементы
            Console.WriteLine("\nЗадание 3.11: Удаление строк с нулевыми элементами (двумерный массив)");
            int rows = 5, cols = 5; // Пример с фиксированным размером
            int[,] matrixA = new int[rows, cols];

            FillMatrix(matrixA, rand);
            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrixA);

            void RemoveRowsWithZeros(int[,] mat)
            {
                bool[] rowsToDelete = new bool[mat.GetLength(0)];

                // Отмечаем строки для удаления
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        if (mat[i, j] == 0)
                        {
                            rowsToDelete[i] = true;
                            break;
                        }
                    }
                }

                // Формируем новую матрицу без отмеченных строк
                int newRowCount = rowsToDelete.Count(r => !r);
                int[,] newMatrix = new int[newRowCount, mat.GetLength(1)];
                int newRow = 0;

                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    if (!rowsToDelete[i])
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            newMatrix[newRow, j] = mat[i, j];
                        }
                        newRow++;
                    }
                }

                Console.WriteLine("\nМатрица после удаления строк с нулями:");
                PrintMatrix(newMatrix);
            }

            RemoveRowsWithZeros(matrixA);

            Console.WriteLine("\nВариант (б): Удаление строк с нулевыми элементами в одномерном массиве");
            int[] oneDMatrixA = new int[rows * cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    oneDMatrixA[i * cols + j] = matrixA[i, j];
                }
            }

            void RemoveRowsWithZerosInOneD(int[] mat, int rowCount, int colCount)
            {
                bool[] rowsToDelete = new bool[rowCount];

                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        if (mat[i * colCount + j] == 0)
                        {
                            rowsToDelete[i] = true;
                            break;
                        }
                    }
                }

                Console.WriteLine("\nРезультат в одномерной последовательности:");
                for (int i = 0; i < rowCount; i++)
                {
                    if (!rowsToDelete[i])
                    {
                        for (int j = 0; j < colCount; j++)
                        {
                            Console.Write($"{mat[i * colCount + j],5}");
                        }
                        Console.WriteLine();
                    }
                }
            }

            RemoveRowsWithZerosInOneD(oneDMatrixA, rows, cols);
        }

        else if (checker == 3.12)
        {
            // Задание 12: Привести матрицу к виду с нулями ниже главной диагонали
            Console.WriteLine("\nЗадание 3.12: Обнуление элементов ниже главной диагонали (двумерный массив)");
            int matrixSize = 4; // Пример квадратной матрицы, можно менять
            int[,] matrixB = new int[matrixSize, matrixSize];

            FillMatrix(matrixB, rand);
            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrixB);

            void ToUpperTriangularMatrix(int[,] mat)
            {
                for (int j = 0; j < mat.GetLength(1) - 1; j++)
                {
                    for (int k = j + 1; k < mat.GetLength(0); k++)
                    {
                        double p = (double)mat[k, j] / mat[j, j];
                        for (int m = j; m < mat.GetLength(1); m++)
                        {
                            mat[k, m] -= (int)(mat[j, m] * p);
                        }
                    }
                }

                Console.WriteLine("\nМатрица после обнуления элементов ниже главной диагонали:");
                PrintMatrix(mat);
            }

            ToUpperTriangularMatrix(matrixB);

            Console.WriteLine("\nВариант (б): Обнуление элементов ниже главной диагонали в одномерной последовательности");
            int[] oneDMatrixB = new int[matrixSize * matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    oneDMatrixB[i * matrixSize + j] = matrixB[i, j];
                }
            }

            void ToUpperTriangularInOneD(int[] mat, int size)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    for (int k = j + 1; k < size; k++)
                    {
                        double p = (double)mat[k * size + j] / mat[j * size + j];
                        for (int m = j; m < size; m++)
                        {
                            mat[k * size + m] -= (int)(mat[j * size + m] * p);
                        }
                    }
                }

                Console.WriteLine("\nРезультат в одномерной последовательности:");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"{mat[i * size + j],5}");
                    }
                    Console.WriteLine();
                }
            }

            ToUpperTriangularInOneD(oneDMatrixB, matrixSize);
        }

        else if (checker == 3.13)
        {
            // Задание 13: Привести матрицу к виду с нулями выше главной диагонали
            Console.WriteLine("\nЗадание 3.13: Обнуление элементов выше главной диагонали (двумерный массив)");
            int matrixSize = 4;
            int[,] matrixC = new int[matrixSize, matrixSize];

            FillMatrix(matrixC, rand);
            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrixC);

            void ToLowerTriangularMatrix(int[,] mat)
            {
                for (int j = mat.GetLength(1) - 1; j > 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        double p = (double)mat[k, j] / mat[j, j];
                        for (int m = j; m >= 0; m--)
                        {
                            mat[k, m] -= (int)(mat[j, m] * p);
                        }
                    }
                }

                Console.WriteLine("\nМатрица после обнуления элементов выше главной диагонали:");
                PrintMatrix(mat);
            }

            ToLowerTriangularMatrix(matrixC);

            Console.WriteLine("\nВариант (б): Обнуление элементов выше главной диагонали в одномерной последовательности");
            int[] oneDMatrixC = new int[matrixSize * matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    oneDMatrixC[i * matrixSize + j] = matrixC[i, j];
                }
            }

            void ToLowerTriangularInOneD(int[] mat, int size)
            {
                for (int j = size - 1; j > 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        double p = (double)mat[k * size + j] / mat[j * size + j];
                        for (int m = j; m >= 0; m--)
                        {
                            mat[k * size + m] -= (int)(mat[j * size + m] * p);
                        }
                    }
                }

                Console.WriteLine("\nРезультат в одномерной последовательности:");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"{mat[i * size + j],5}");
                    }
                    Console.WriteLine();
                }
            }
            ToLowerTriangularInOneD(oneDMatrixC, matrixSize);
        }

    }

    //voids for code
    static void FillMatrix(int[,] matrix, Random rand)
    {// Заполняет матрицы рандомными числами
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rand.Next(-10, 10); // Случайные числа от -10 до 10
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {// Выводит саму матрицу 
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],5}");
            }
            Console.WriteLine();
        }
    }
}

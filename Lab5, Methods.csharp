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



class Program
{//Лабораторная работа №5
 // 1 Уровень 1 Задача, 1 Уровень 2 Задача, 1 Уровень 3 Задача,
 // 2 Уровень 25 Задача, 2 Уровень 26 Задача, 2 Уровень 27 Задача,
 // 3 Уровень 1 Задача, 3 Уровень 2 Задача, 3 Уровень 3 Задача
    static void Main()
    {
        Console.WriteLine("1 УРОВЕНЬ 1 ЗАДАЧА");
        Task11.Run();

        Console.WriteLine("\n1 УРОВЕНЬ 2 ЗАДАЧА");
        Task12.Run();

        Console.WriteLine("\n1 УРОВЕНЬ 3 ЗАДАЧА");
        Task13.Run();

        Console.WriteLine("\n2 УРОВЕНЬ 25 ЗАДАЧА");
        Task225.Run();

        Console.WriteLine("\n2 УРОВЕНЬ 26 ЗАДАЧА");
        Task226.Run();

        Console.WriteLine("\n2 УРОВЕНЬ 27 ЗАДАЧА");
        Task227.Run();

        Console.WriteLine("\n3 УРОВЕНЬ 1 ЗАДАЧА");
        Task31.Run();

        Console.WriteLine("\n3 УРОВЕНЬ 2 ЗАДАЧА");
        Task32.Run();

        Console.WriteLine("\n3 УРОВЕНЬ 3 ЗАДАЧА");
        Task33.Run();
    }
}

class Task11
{
    public static void Run()
    {
        Console.WriteLine("Количество способов отбора команды:");
        Console.WriteLine("Из 8 кандидатов: " + CalculateCombinations(8, 5));
        Console.WriteLine("Из 10 кандидатов: " + CalculateCombinations(10, 5));
        Console.WriteLine("Из 11 кандидатов: " + CalculateCombinations(11, 5));
    }

    private static int CalculateCombinations(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    private static int Factorial(int x)
    {
        int result = 1;
        for (int i = 2; i <= x; i++)
        {
            result *= i;
        }
        return result;
    }
}

class Task12
{
    public static void Run()
    {
        //Console.WriteLine("Введите стороны первого треугольника (a, b, c):");
        double a1 = 3; //Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Сторона а1 " + a1);
        double b1 = 4; //Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Сторона b1 " + b1);
        double c1 = 5; //Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Сторона c1 " + c1);

        //Console.WriteLine("Введите стороны второго треугольника (a, b, c):");
        double a2 = 4; //Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Сторона а2 " + a2);
        double b2 = 5; //Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Сторона b2 " + b2);
        double c2 = 6; //Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Сторона c2 " + c2);

        string result = CompareTrianglesByArea(a1, b1, c1, a2, b2, c2);
        Console.WriteLine(result);
    }

    private static string CompareTrianglesByArea(double a1, double b1, double c1, double a2, double b2, double c2)
    {
        double area1 = CalculateTriangleArea(a1, b1, c1);
        double area2 = CalculateTriangleArea(a2, b2, c2);

        if (area1 > area2)
            return "Первый треугольник имеет большую площадь.";
        else if (area2 > area1)
            return "Второй треугольник имеет большую площадь.";
        else
            return "Треугольники имеют равные площади.";
    }

    private static double CalculateTriangleArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

class Task13
{
    public static void Run()
    {
        Console.WriteLine("Пройденное расстояние через 1 час:");
        Console.WriteLine("Первый велосипедист: " + CalculateDistanceAfterTime(10, 1, 1));
        Console.WriteLine("Второй велосипедист: " + CalculateDistanceAfterTime(9, 1.6, 1));

        Console.WriteLine("\nПройденное расстояние через 4 часа:");
        Console.WriteLine("Первый велосипедист: " + CalculateDistanceAfterTime(10, 1, 4));
        Console.WriteLine("Второй велосипедист: " + CalculateDistanceAfterTime(9, 1.6, 4));

        double catchUpTime = CalculateCatchUpTime(10, 1, 9, 1.6);
        Console.WriteLine("\nВремя, когда второй догонит первого: " + catchUpTime + " часов");
    }

    private static double CalculateDistanceAfterTime(double initialVelocity, double acceleration, double time)
    {
        return initialVelocity * time + 0.5 * acceleration * time * time;
    }

    private static double CalculateCatchUpTime(double v1, double a1, double v2, double a2)
    {
        return (v2 - v1) / (a1 - a2);
    }
}


class Task225
{
    public static void Run()
    {
        int[,] matrix1 = { { -3, 5, -1 }, { -2, -4, 6 }, { 3, -2, -5 } };
        int[,] matrix2 = { { 2, -1, -3 }, { -4, -1, -7 }, { 0, 4, -8 } };

        Console.WriteLine("Исходная матрица 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Исходная матрица 2:");
        PrintMatrix(matrix2);

        int maxNegativesRow1 = FindRowWithMostNegatives(matrix1);
        int maxNegativesRow2 = FindRowWithMostNegatives(matrix2);

        Console.WriteLine("Строка с максимальным количеством отрицательных элементов в первой матрице: " + maxNegativesRow1);
        Console.WriteLine("Строка с максимальным количеством отрицательных элементов во второй матрице: " + maxNegativesRow2);
    }

    private static int FindRowWithMostNegatives(int[,] matrix)
    {
        int maxNegativesCount = -1;
        int rowWithMaxNegatives = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int negativesCount = CountNegativesInRow(matrix, i);
            if (negativesCount > maxNegativesCount)
            {
                maxNegativesCount = negativesCount;
                rowWithMaxNegatives = i;
            }
        }

        return rowWithMaxNegatives;
    }

    private static int CountNegativesInRow(int[,] matrix, int row)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[row, j] < 0)
                count++;
        }
        return count;
    }
    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Task226
{
    public static void Run()
    {
        int[,] matrix1 = { { -3, 5, -1 }, { -2, -4, 6 }, { -3, -2, -5 } };
        int[,] matrix2 = { { 2, -1, -3 }, { -4, -1, -7 }, { 0, 4, -8 } };
        Console.WriteLine("Исходная матрица 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Исходная матрица 2:");
        PrintMatrix(matrix2);

        int row1 = FindRowWithMostNegatives(matrix1);
        int row2 = FindRowWithMostNegatives(matrix2);

        if (row1 != -1 && row2 != -1)
        {
            SwapRows(matrix1, matrix2, row1, row2);

            Console.WriteLine("Матрица 1 после обмена строк:");
            PrintMatrix(matrix1);

            Console.WriteLine("Матрица 2 после обмена строк:");
            PrintMatrix(matrix2);
        }
        else
        {
            Console.WriteLine("Обмен невозможен: строки с максимальным количеством отрицательных элементов не найдены.");
        }
    }

    private static int FindRowWithMostNegatives(int[,] matrix)
    {
        int maxNegativesCount = -1;
        int rowWithMaxNegatives = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int negativesCount = CountNegativesInRow(matrix, i);
            if (negativesCount > maxNegativesCount)
            {
                maxNegativesCount = negativesCount;
                rowWithMaxNegatives = i;
            }
        }

        return rowWithMaxNegatives;
    }

    private static int CountNegativesInRow(int[,] matrix, int row)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[row, j] < 0)
                count++;
        }
        return count;
    }

    private static void SwapRows(int[,] matrix1, int[,] matrix2, int row1, int row2)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            int temp = matrix1[row1, j];
            matrix1[row1, j] = matrix2[row2, j];
            matrix2[row2, j] = temp;
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


class Task227
{
    public static void Run()
    {
        int[,] matrix1 = { { 2, -1, 4 }, { 3, -4, -7 }, { 5, -2, 8 } };
        int[,] matrix2 = { { -6, 3, -2 }, { 8, 1, -5 }, { 7, -3, 2 } };

        Console.WriteLine("Исходная матрица 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Исходная матрица 2:");
        PrintMatrix(matrix2);

        ProcessMatrix(matrix1);
        ProcessMatrix(matrix2);

        Console.WriteLine("Матрица 1 после обработки:");
        PrintMatrix(matrix1);

        Console.WriteLine("Матрица 2 после обработки:");
        PrintMatrix(matrix2);
    }

    private static void ProcessMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int maxIndex = FindMaxInRow(matrix, i);
            if (i % 2 == 0)
            {
                matrix[i, maxIndex] = 0; // Для четных строк заменяем на 0
            }
            else
            {
                matrix[i, maxIndex] *= (maxIndex + 1); // Для нечетных строк умножаем на номер столбца (maxIndex + 1)
            }
        }
    }

    private static int FindMaxInRow(int[,] matrix, int row)
    {
        int maxIndex = 0;
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[row, j] > matrix[row, maxIndex])
            {
                maxIndex = j;
            }
        }
        return maxIndex;
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Task31
{
    public delegate double SumTerm(double x, int i);

    public static void Run()
    {
        double a1 = 0, b1 = 1, h1 = 0.1;
        double a2 = Math.PI / 5, b2 = Math.PI, h2 = Math.PI / 25;

        CalculateAndPrintSum(a1, b1, h1, SumTerm1);
        CalculateAndPrintSum(a2, b2, h2, SumTerm2);
    }

    private static void CalculateAndPrintSum(double a, double b, double h, SumTerm termFunc)
    {
        for (double x = a; x <= b; x += h)
        {
            double sum = 0;
            int i = 1;
            double term;
            do
            {
                term = termFunc(x, i);
                sum += term;
                i++;
            } while (Math.Abs(term) > 1e-6);  // условие выхода по точности
            Console.WriteLine($"Сумма при x = {x:F2}: {sum:F4}");
        }
    }

    private static double SumTerm1(double x, int i)
    {
        return Math.Cos(i * x) / Factorial(i);
    }

    private static double SumTerm2(double x, int i)
    {
        return Math.Pow(-1, i) * Math.Cos(i * x) / (i * i);
    }

    private static double Factorial(int n)
    {
        double result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}


class Task32
{
    public delegate void SortDelegate(int[] row);

    public static void Run()
    {
        int[,] matrix = {
            { 3, 5, 1, 8 },
            { 7, 2, 4, 6 },
            { 9, 3, 5, 1 },
            { 4, 8, 6, 2 }
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        ProcessMatrix(matrix, SortAscending, SortDescending);

        Console.WriteLine("Матрица после обработки:");
        PrintMatrix(matrix);
    }

    private static void ProcessMatrix(int[,] matrix, SortDelegate sortEven, SortDelegate sortOdd)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] row = GetRow(matrix, i);
            if (i % 2 == 0)
                sortEven(row);
            else
                sortOdd(row);
            SetRow(matrix, i, row);
        }
    }

    private static int[] GetRow(int[,] matrix, int rowIndex)
    {
        int[] row = new int[matrix.GetLength(1)];
        for (int j = 0; j < row.Length; j++)
        {
            row[j] = matrix[rowIndex, j];
        }
        return row;
    }

    private static void SetRow(int[,] matrix, int rowIndex, int[] row)
    {
        for (int j = 0; j < row.Length; j++)
        {
            matrix[rowIndex, j] = row[j];
        }
    }

    private static void SortAscending(int[] row)
    {
        Array.Sort(row);
    }

    private static void SortDescending(int[] row)
    {
        Array.Sort(row);
        Array.Reverse(row);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Task33
{
    public delegate void SwapDelegate(int[] array);

    public static void Run()
    {
        int[] array = { 1, 3, 5, 7, 9, 11 };
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        double average = CalculateAverage(array);
        Console.WriteLine("Среднее арифметическое: " + average);

        SwapDelegate swapMethod;
        if (array[0] > average)
        {
            swapMethod = SwapStartingFromFirst;
        }
        else
        {
            swapMethod = SwapStartingFromLast;
        }
        swapMethod(array);

        Console.WriteLine("Массив после перестановки:");
        PrintArray(array);

        int sum = CalculateSumOfOddIndexedElements(array);
        Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
    }

    private static double CalculateAverage(int[] array)
    {
        double sum = 0;
        foreach (int item in array)
        {
            sum += item;
        }
        return sum / array.Length;
    }

    private static void SwapStartingFromFirst(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i += 2)
        {
            int temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
        }
    }

    private static void SwapStartingFromLast(int[] array)
    {
        for (int i = array.Length - 1; i > 0; i -= 2)
        {
            int temp = array[i];
            array[i] = array[i - 1];
            array[i - 1] = temp;
        }
    }

    private static int CalculateSumOfOddIndexedElements(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }

    private static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

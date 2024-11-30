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
using System.ServiceModel;
using System.ServiceProcess;
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
using System.Runtime.Intrinsics.X86;
using C = System.Console; //console
using dl = System.Decimal;//decimal
using str = System.String;//string
using l = System.Int64;   //long
using u = System.UInt64;  //Ulong


/* ¡Adelante Barcelona, adelante Cataluña! Visca el Barça! Visca Catalunya!
   ¡Al diablo con todos los demás, porque lo más importante en la vida es el fútbol!
*/
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------


class Program
{
    // Лабораторная Работа №1
    static void Main()
    {
        Console.WriteLine("Choose what program to use - ");
        Console.WriteLine("1 - 1 уровень и 2 уровень Лабораторной работы");
        Console.WriteLine("2 - 3 уровень Лабораторной работы");
        Console.Write("Enter your choice - ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            RunFirstLab();
        }
        else if (choice == "2")
        {
            RunThirdLab();
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    static void RunFirstLab()
    {
        // Lvl1 Ex1
        ulong svg1 = 0;
        for (ulong i = 2; i <= 35; i = i + 3)
        {
            svg1 += i;
        }
        Console.WriteLine("Summ Numbers - " + svg1);

        // Lvl1 Ex10
        ulong num10 = 3;
        ulong res10 = 1;
        for (ulong i = 0; i < 7; i++)
        {
            res10 = res10 * num10;
        }
        Console.WriteLine("3 in 7 degree - " + res10);

        // Lvl1 Ex18
        ulong svg18 = 10;
        ulong res18 = 10;
        for (ulong i = 3; i <= 24; i += 3)
        {
            svg18 = svg18 * 2;
            Console.WriteLine("Ex18. After " + i + " hours it will be " + svg18 + " cells");
        }

        // Lvl2 Ex5
        Console.Write("Enter number N - ");
        ulong n1 = ulong.Parse(Console.ReadLine());
        Console.Write("Enter number M - ");
        ulong m1 = ulong.Parse(Console.ReadLine());

        ulong quot = 0;
        ulong remain = n1;
        while (remain >= m1)
        {
            remain -= m1;
            quot++;
        }
        Console.WriteLine("Quot of division - " + quot);
        Console.WriteLine("Remainder of division - " + remain);

        // Lvl2 Ex7
        int day7a = 1;
        double distance7a = 10;
        double totalDistance7a = 0;
        while (day7a <= 7)
        {
            totalDistance7a += distance7a;
            distance7a *= 1.1;
            day7a++;
        }
        Console.WriteLine("Answer for item A - " + totalDistance7a);

        int day7b = 1;
        double distance7b = 10;
        double totalDistance7b = 0;
        while (totalDistance7b < 100)
        {
            distance7b *= 1.1;
            totalDistance7b += distance7b;
            day7b++;
        }
        Console.WriteLine("Answer for item B - " + day7b);

        int day7c = 1;
        double distance7c = 10;
        while (distance7c <= 20)
        {
            distance7c *= 1.1;
            day7c++;
        }
        Console.WriteLine("Answer for item C - " + day7c);

        // Lvl2 Ex8
        double StartSum = 10000;
        double CurSum = StartSum;
        double Rate = 0.08;
        ulong months = 0;
        while (CurSum < 2 * StartSum)
        {
            CurSum *= (1 + Rate);
            months++;
        }
        Console.WriteLine("Sum get doubled after - " + months + " months");
    }

    static void RunThirdLab()
    {
        // Лабораторная 3 уровень 1 задание
        double a = 0.1;
        double b = 1.0;
        double h = 0.1;
        const double e = 0.0001;

        Console.WriteLine("x" + "               " + "sum" + "             " + "cos(x)" + "          " + "Difference");
        Console.WriteLine("-------------------------------------------------------------");

        for (double x = a; x <= b; x += h)
        {
            double sum = CalcForSum(x, e);
            double cosx = Math.Cos(x);
            double diff = Math.Abs(sum - cosx);

            Console.WriteLine($"{x:F1}\t\t{sum:F6}\t{cosx:F6}\t{diff:E6}");
        }
    }

    static double CalcForSum(double x, double e)
    {
        double sum = 0;
        double term = 1;
        int i = 0;

        while (Math.Abs(term) >= e)
        {
            sum += term;
            i++;
            term = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / factorial(2 * i);
        }

        return sum;
    }

    static double factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        double result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;

        return result;
    }
}

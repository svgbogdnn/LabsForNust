//svg does precious
using System; // Аналог <iostream> для работы с консольюи основными функциями
using System.Collections.Generic; // Аналог <vector>, <list>, <map>, <set>,< unordered_map >, < unordered_set >, < stack >, < queue >
using System.Text; // Аналог <string>, <cstring> (для работысо строками и StringBuilder)
using System.Linq; // Аналог <algorithm> (для работы с LINQ,сортировок, поиска и т.д.)
using System.IO; // Аналог <cstdio>, <fstream> (работа сфайлами)
using System.Globalization; // Аналог <iomanip> (для форматирования)
using System.Collections; // Работа с различными коллекциями (например, ArrayList)
using System.Threading; // Потоки и многопоточность
using System.Runtime.Serialization; // Аналог <stdexcept> (работа с исключениями)
using System.Reflection; // Аналог <typeinfo> (информация о типах, рефлексия)
using System.Diagnostics; // Аналог <utility>, <std::pair> (вспомогательные функции и классы)
using System.ComponentModel; // Дополнительные утилиты и атрибуты
using System.Numerics; // Работа с большими числами и математическими операциями
using System.Globalization;
using System.Diagnostics;
using System.Net;
using System.Numerics;
// Для работы с потоками данных:
using System.Threading.Tasks; // Асинхронные задачи
// Для работы с датами и временем:
using System.Timers; // Для работы с таймерами и временем
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
using l = System.Int64; //long
using u = System.UInt64; //Ulong
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
Vogue
Ra-ra-racks came in, hello (Hello?)
Fu-fucked this girl on Vogue
Big Range, ain't no Evoque
Big chain, this ain't a choker
Sh-sh-she like when her neck get choked
I know that her boyfriend knows
You tell white lies like cocaine
I know that her boyfriend knows
You tell white— (Cocaine)
She hate when her man get home
*/
/* ¡Adelante Barcelona, adelante Cataluña! Visca el Barça! Visca Catalunya!
 ¡Al diablo con todos los demás, porque lo más importante en la vida es el
fútbol!
*/
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------

// Form1.cs

using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Поля для игры (Таск III)
        private int gamePoints = 8;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            // Инициализация начального значения очков игры
            labelPointsValue.Text = gamePoints.ToString();
        }
        // ====== Задача I: Сложение двух чисел (с TextBox) ======
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = a + b;
                textBoxResult.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }
        // ====== Задача II: Построение графика функции z = x * sin(x) ======
        // a = 0; b = 3pi; n = 20
        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int w = panelGraph.Width;
            int h = panelGraph.Height;
            // Устанавливаем систему координат с началом в левом нижнем углу
            g.TranslateTransform(0, h);
            g.ScaleTransform(1, -1);
            double a = 0;
            double b = 3 * Math.PI;
            int n = 20;
            double step = (b - a) / n;
            // Для масштабирования берём примерно:
            // f(x)= x*sin(x) на [0,3pi] имеет минимальное значение около -4.71 и
            максимальное около 7.85
        double minY = -4.71;
            double maxY = 7.85;
            double xScale = w / (b - a);
            double yScale = h / (maxY - minY);
            // Рисуем оси: ось X проходит на уровне y = -minY, ось Y – по x=0
            float xAxisY = (float)(-minY * yScale);
            g.DrawLine(Pens.Black, 0, xAxisY, w, xAxisY);
            g.DrawLine(Pens.Black, 0, 0, 0, h);
            // Вычисляем точки графика
            PointF[] points = new PointF[n + 1];
            for (int i = 0; i <= n; i++)
            {
                double x = a + i * step;
                double y = x * Math.Sin(x);
                float px = (float)(x * xScale);
                // Смещаем y так, чтобы минимальное значение оказалось на нуле
                float py = (float)((y - minY) * yScale);
                points[i] = new PointF(px, py);
            }
            // Рисуем ломаную линию графика
            if (points.Length > 1)
            {
                g.DrawLines(Pens.Blue, points);
            }
            // Отмечаем точки маленькими кружками
            foreach (PointF p in points)
            {
                g.FillEllipse(Brushes.Red, p.X - 2, p.Y - 2, 4, 4);
            }
        }
        // ====== Задача III: Игра "Карусель‑ лото" ======
        // Обработчик кнопки "Сделать ставку"
        private void buttonBet_Click(object sender, EventArgs e)
        {
            int bet;
            if (!int.TryParse(textBoxBet.Text, out bet))
            {
                MessageBox.Show("Неверная ставка!");
                return;
            }
            if (bet < 1)
            {
                MessageBox.Show("Ставка должна быть не менее 1 очка.");
                return;
            }
            if (bet > gamePoints)
            {
                MessageBox.Show("Недостаточно очков для такой ставки.");
                return;
            }
            int chosen;
            if (!int.TryParse(textBoxCombination.Text, out chosen))
            {
                MessageBox.Show("Неверная комбинация!");
                return;
            }
            // Допустим, комбинация должна быть от 1 до 9
            if (chosen < 1 || chosen > 9)
            {
                MessageBox.Show("Комбинация должна быть от 1 до 9.");
                return;
            }
            // Ставка списывается сразу
            gamePoints -= bet;
            UpdatePointsDisplay();
            // Симулируем выпадение случайного числа от 0 до 9
            int result = random.Next(0, 10);
            richTextBoxGameLog.AppendText("Выпало число: " + result +
           Environment.NewLine);
            if (result == 0)
            {
                // При выпадении 0 все поставленные очки теряются (ставка уже
                списана)
 richTextBoxGameLog.AppendText("Выпал ноль! Все поставленные очки
проиграны." + Environment.NewLine);
            }
            else if (result == chosen)
            {
 // В случае успеха игрок получает возвращённую ставку плюс приз.
 // Пусть приз будет равен удвоенной ставке (то есть чистая прибыль
= 2 * bet)
 int winAmount = bet * 2;
                // Возвращаем поставленные очки и добавляем выигрыш
                gamePoints += bet + winAmount;
                richTextBoxGameLog.AppendText("Угадали комбинацию! Вы выигрываете
               " + winAmount + " очков." + Environment.NewLine);
            }
            else
            {
                // Ставка проиграна – ничего не возвращается
                richTextBoxGameLog.AppendText("Не угадали. Ставка проиграна." +
               Environment.NewLine);
            }
            UpdatePointsDisplay();
            CheckGameOver();
        }
        // Обработчик кнопки "Пропустить раунд"
        private void buttonSkip_Click(object sender, EventArgs e)
        {
            richTextBoxGameLog.AppendText("Раунд пропущен." +
           Environment.NewLine);
        }
        // Метод обновления отображения текущих очков
        private void UpdatePointsDisplay()
        {
            labelPointsValue.Text = gamePoints.ToString();
        }
        // Проверка на окончание игры
        private void CheckGameOver()
        {
            if (gamePoints <= 0)
            {
                MessageBox.Show("Очки закончились! Игра окончена.");
                buttonBet.Enabled = false;
                buttonSkip.Enabled = false;
            }
        }
    }
}


// Form1.Designer.cs

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть
        удален; иначе ложно.</param>
 protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTask1 = new System.Windows.Forms.TabPage();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.tabPageTask2 = new System.Windows.Forms.TabPage();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.tabPageTask3 = new System.Windows.Forms.TabPage();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelPointsValue = new System.Windows.Forms.Label();
            this.labelBet = new System.Windows.Forms.Label();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.labelCombination = new System.Windows.Forms.Label();
            this.textBoxCombination = new System.Windows.Forms.TextBox();
            this.buttonBet = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.richTextBoxGameLog = new System.Windows.Forms.RichTextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageTask1.SuspendLayout();
            this.tabPageTask2.SuspendLayout();
            this.tabPageTask3.SuspendLayout();
            this.SuspendLayout();
            //
            // tabControlMain
            //
            this.tabControlMain.Controls.Add(this.tabPageTask1);
            this.tabControlMain.Controls.Add(this.tabPageTask2);
            this.tabControlMain.Controls.Add(this.tabPageTask3);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(600, 450);
            this.tabControlMain.TabIndex = 0;
            //
            // tabPageTask1
            //
            this.tabPageTask1.Controls.Add(this.labelA);
            this.tabPageTask1.Controls.Add(this.textBoxA);
            this.tabPageTask1.Controls.Add(this.labelB);
            this.tabPageTask1.Controls.Add(this.textBoxB);
            this.tabPageTask1.Controls.Add(this.buttonCalculate);
            this.tabPageTask1.Controls.Add(this.labelResult);
            this.tabPageTask1.Controls.Add(this.textBoxResult);
            this.tabPageTask1.Location = new System.Drawing.Point(4, 22);
            this.tabPageTask1.Name = "tabPageTask1";
            this.tabPageTask1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTask1.Size = new System.Drawing.Size(592, 424);
            this.tabPageTask1.TabIndex = 0;
            this.tabPageTask1.Text = "Задача I: Сложение";
            this.tabPageTask1.UseVisualStyleBackColor = true;
            //
            // labelA
            //
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(20, 20);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(59, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Число A:";
            //
            // textBoxA
            //
            this.textBoxA.Location = new System.Drawing.Point(100, 17);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 1;
            //
            // labelB
            //
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(20, 50);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(59, 13);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "Число B:";
            //
            // textBoxB
            //
            this.textBoxB.Location = new System.Drawing.Point(100, 47);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 3;
            //
            // buttonCalculate
            //
            this.buttonCalculate.Location = new System.Drawing.Point(20, 80);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(180, 30);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Вычислить сумму";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new
           System.EventHandler(this.buttonCalculate_Click);
            //
            // labelResult
            //
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(20, 120);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(61, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Результат:";
            //
            // textBoxResult
            //
            this.textBoxResult.Location = new System.Drawing.Point(100, 117);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 6;
            //
            // tabPageTask2
            //
            this.tabPageTask2.Controls.Add(this.panelGraph);
            this.tabPageTask2.Location = new System.Drawing.Point(4, 22);
            this.tabPageTask2.Name = "tabPageTask2";
            this.tabPageTask2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTask2.Size = new System.Drawing.Size(592, 424);
            this.tabPageTask2.TabIndex = 1;
            this.tabPageTask2.Text = "Задача II: График";
            this.tabPageTask2.UseVisualStyleBackColor = true;
            //
            // panelGraph
            //
            this.panelGraph.BackColor = System.Drawing.Color.White;
            this.panelGraph.BorderStyle =
           System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraph.Location = new System.Drawing.Point(10, 10);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(560, 400);
            this.panelGraph.TabIndex = 0;
            this.panelGraph.Paint += new
           System.Windows.Forms.PaintEventHandler(this.panelGraph_Paint);
            //
            // tabPageTask3
            //
            this.tabPageTask3.Controls.Add(this.labelPoints);
            this.tabPageTask3.Controls.Add(this.labelPointsValue);
            this.tabPageTask3.Controls.Add(this.labelBet);
            this.tabPageTask3.Controls.Add(this.textBoxBet);
            this.tabPageTask3.Controls.Add(this.labelCombination);
            this.tabPageTask3.Controls.Add(this.textBoxCombination);
            this.tabPageTask3.Controls.Add(this.buttonBet);
            this.tabPageTask3.Controls.Add(this.buttonSkip);
            this.tabPageTask3.Controls.Add(this.richTextBoxGameLog);
            this.tabPageTask3.Location = new System.Drawing.Point(4, 22);
            this.tabPageTask3.Name = "tabPageTask3";
            this.tabPageTask3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTask3.Size = new System.Drawing.Size(592, 424);
            this.tabPageTask3.TabIndex = 2;
            this.tabPageTask3.Text = "Задача III: Игра";
            this.tabPageTask3.UseVisualStyleBackColor = true;
            //
            // labelPoints
            //
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(20, 20);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(44, 13);
            this.labelPoints.TabIndex = 0;
            this.labelPoints.Text = "Очки:";
            //
            // labelPointsValue
            //
            this.labelPointsValue.AutoSize = true;
            this.labelPointsValue.Location = new System.Drawing.Point(80, 20);
            this.labelPointsValue.Name = "labelPointsValue";
            this.labelPointsValue.Size = new System.Drawing.Size(13, 13);
            this.labelPointsValue.TabIndex = 1;
            this.labelPointsValue.Text = "8";
            //
            // labelBet
            //
            this.labelBet.AutoSize = true;
            this.labelBet.Location = new System.Drawing.Point(20, 50);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(45, 13);
            this.labelBet.TabIndex = 2;
            this.labelBet.Text = "Ставка:";
            //
            // textBoxBet
            //
            this.textBoxBet.Location = new System.Drawing.Point(80, 47);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(50, 20);
            this.textBoxBet.TabIndex = 3;
            this.textBoxBet.Text = "1";
            //
            // labelCombination
            //
            this.labelCombination.AutoSize = true;
            this.labelCombination.Location = new System.Drawing.Point(20, 80);
            this.labelCombination.Name = "labelCombination";
            this.labelCombination.Size = new System.Drawing.Size(83, 13);
            this.labelCombination.TabIndex = 4;
            this.labelCombination.Text = "Комбинация:";
            //
            // textBoxCombination
            //
            this.textBoxCombination.Location = new System.Drawing.Point(120, 77);
            this.textBoxCombination.Name = "textBoxCombination";
            this.textBoxCombination.Size = new System.Drawing.Size(50, 20);
            this.textBoxCombination.TabIndex = 5;
            this.textBoxCombination.Text = "1";
            //
            // buttonBet
            //
            this.buttonBet.Location = new System.Drawing.Point(20, 110);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(150, 30);
            this.buttonBet.TabIndex = 6;
            this.buttonBet.Text = "Сделать ставку";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            //
            // buttonSkip
            //
            this.buttonSkip.Location = new System.Drawing.Point(180, 110);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(150, 30);
            this.buttonSkip.TabIndex = 7;
            this.buttonSkip.Text = "Пропустить раунд";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new
           System.EventHandler(this.buttonSkip_Click);
            //
            // richTextBoxGameLog
            //
            this.richTextBoxGameLog.Location = new System.Drawing.Point(20, 150);
            this.richTextBoxGameLog.Name = "richTextBoxGameLog";
            this.richTextBoxGameLog.Size = new System.Drawing.Size(540, 250);
            this.richTextBoxGameLog.TabIndex = 8;
            this.richTextBoxGameLog.Text = "";
            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Лабораторная работа – Решение задач";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTask1.ResumeLayout(false);
            this.tabPageTask1.PerformLayout();
            this.tabPageTask2.ResumeLayout(false);
            this.tabPageTask3.ResumeLayout(false);
            this.tabPageTask3.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTask1;
        private System.Windows.Forms.TabPage tabPageTask2;
        private System.Windows.Forms.TabPage tabPageTask3;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelPointsValue;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Label labelCombination;
        private System.Windows.Forms.TextBox textBoxCombination;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.RichTextBox richTextBoxGameLog;
    }
}

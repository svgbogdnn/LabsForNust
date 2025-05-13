// Form1.cs

using System;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // Два счета
        private Account account1;
        private Account account2;
        // Список доступных валют
        private Currency[] currencies;
        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }
        // Инициализация данных (два счета, массив валют, ComboBox-ы и пр.)
        private void InitializeData()
        {
            // Создаем объекты счетов
            account1 = new Account(500.0); // для примера, начальный баланс 500
            руб.
             account2 = new Account(1000.0); // для примера, начальный баланс 1000
            руб.

             currencies = new Currency[]
             {
 new Currency("RUB", 1.0),
 new Currency("CNY", 70.0), // примерный курс
 new Currency("USD", 80.0), // примерный курс
             };
            // Заполняем ComboBox'ы для выбора валюты счетов
            foreach (var c in currencies)
            {
                comboBoxAccountCurrency1.Items.Add(c.Code);
                comboBoxAccountCurrency2.Items.Add(c.Code);
            }
            // По умолчанию RUB
            comboBoxAccountCurrency1.SelectedIndex = 0;
            comboBoxAccountCurrency2.SelectedIndex = 2; // Допустим, сразу "EUR"
            (индекс 2)
 // Заполняем ComboBox'ы для транзакций
 foreach (var c in currencies)
            {
                comboBoxTransactionCurrency1.Items.Add(c.Code);
                comboBoxTransactionCurrency2.Items.Add(c.Code);
            }
            comboBoxTransactionCurrency1.SelectedIndex = 0;
            comboBoxTransactionCurrency2.SelectedIndex = 0;
            // Заполняем ComboBox для "На руках"
            foreach (var c in currencies)
            {
                comboBoxOnHandsCurrency.Items.Add(c.Code);
            }
            comboBoxOnHandsCurrency.SelectedIndex = 0;
            // Первичная отрисовка
            UpdateAccountDisplay1();
            UpdateAccountDisplay2();
            UpdateOnHandsDisplay();
        }
        // Получить объект валюты по коду
        private Currency GetCurrencyByCode(string code)
        {
            foreach (var curr in currencies)
            {
                if (curr.Code == code)
                    return curr;
            }
            return null;
        }
        // Обновление отображения счета 1 в выбранной валюте
        private void UpdateAccountDisplay1()
        {
            Currency selectedCurrency =
           GetCurrencyByCode(comboBoxAccountCurrency1.SelectedItem.ToString());
            double balanceInSelectedCurrency =
           account1.GetBalanceInCurrency(selectedCurrency);
            labelCurrentBalance1.Text = balanceInSelectedCurrency.ToString("F2");
        }
        // Обновление отображения счета 2 в выбранной валюте
        private void UpdateAccountDisplay2()
        {
            Currency selectedCurrency =
           GetCurrencyByCode(comboBoxAccountCurrency2.SelectedItem.ToString());
            double balanceInSelectedCurrency =
           account2.GetBalanceInCurrency(selectedCurrency);
            labelCurrentBalance2.Text = balanceInSelectedCurrency.ToString("F2");
        }
        // Обновление суммы "На руках" (сумма двух счетов) в выбранной валюте
        private void UpdateOnHandsDisplay()
        {
            Currency selectedCurrency =
           GetCurrencyByCode(comboBoxOnHandsCurrency.SelectedItem.ToString());
            double totalBase = account1.Balance + account2.Balance; // Сумма в
            базовой валюте
        double totalInSelectedCurrency = totalBase / selectedCurrency.Rate;
            labelOnHandsValue.Text = totalInSelectedCurrency.ToString("F2");
        }
        // Обработчик изменения валюты для Счета 1
        private void comboBoxAccountCurrency1_SelectedIndexChanged(object sender,
       EventArgs e)
        {
            UpdateAccountDisplay1();
        }
        // Обработчик изменения валюты для Счета 2
        private void comboBoxAccountCurrency2_SelectedIndexChanged(object sender,
       EventArgs e)
        {
            UpdateAccountDisplay2();
        }
        // Обработчик изменения валюты для "На руках"
        private void comboBoxOnHandsCurrency_SelectedIndexChanged(object sender,
       EventArgs e)
        {
            UpdateOnHandsDisplay();
        }
        // Нажали "Зачислить" на Счет 1
        private void buttonDeposit1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTransactionAmount1.Text, out double
           amount))
            {
                Currency transactionCurrency =
               GetCurrencyByCode(comboBoxTransactionCurrency1.SelectedItem.ToString());
                account1.Deposit(amount, transactionCurrency);
                UpdateAccountDisplay1();
                UpdateOnHandsDisplay();
            }
            else
            {
                MessageBox.Show("Введите корректное значение суммы.", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Нажали "Снять" на Счет 1
        private void buttonWithdraw1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTransactionAmount1.Text, out double
           amount))
            {
                Currency transactionCurrency =
               GetCurrencyByCode(comboBoxTransactionCurrency1.SelectedItem.ToString());
                if (!account1.Withdraw(amount, transactionCurrency))
                {
                    MessageBox.Show("Недостаточно средств.", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateAccountDisplay1();
                UpdateOnHandsDisplay();
            }
            else
            {
                MessageBox.Show("Введите корректное значение суммы.", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Нажали "Зачислить" на Счет 2
        private void buttonDeposit2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTransactionAmount2.Text, out double
           amount))
            {
                Currency transactionCurrency =
               GetCurrencyByCode(comboBoxTransactionCurrency2.SelectedItem.ToString());
                account2.Deposit(amount, transactionCurrency);
                UpdateAccountDisplay2();
                UpdateOnHandsDisplay();
            }
            else
            {
                MessageBox.Show("Введите корректное значение суммы.", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Нажали "Снять" на Счет 2
        private void buttonWithdraw2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTransactionAmount2.Text, out double
           amount))
            {
                Currency transactionCurrency =
               GetCurrencyByCode(comboBoxTransactionCurrency2.SelectedItem.ToString());
                if (!account2.Withdraw(amount, transactionCurrency))
                {
                    MessageBox.Show("Недостаточно средств.", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateAccountDisplay2();
                UpdateOnHandsDisplay();
            }
            else
            {
                MessageBox.Show("Введите корректное значение суммы.", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    // Класс "Валюта"
    public class Currency
    {
        private string code;
        private double rate;
        // Свойства для публичного чтения
        public string Code { get { return code; } }
        public double Rate { get { return rate; } }
        public Currency(string code, double rate)
        {
            this.code = code;
            this.rate = rate;
        }
    }
    // Класс "Счет"
    public class Account
    {
        // Баланс хранится в базовой валюте (RUB)
        private double balance;
        // Свойство только для чтения (в базовой валюте)
        public double Balance { get { return balance; } }
        public Account(double initialBalance = 0.0)
        {
            balance = initialBalance;
        }
        // Зачисление (конвертируем сумму в RUB и добавляем)
        public void Deposit(double amount, Currency currency)
        {
            double amountInBase = amount * currency.Rate;
            balance += amountInBase;
        }
        // Снятие (конвертируем сумму в RUB и проверяем наличие)
        public bool Withdraw(double amount, Currency currency)
        {
            double amountInBase = amount * currency.Rate;
            // Рассчитываем комиссию 1%
            double commission = amountInBase * 0.01;
            // Общая сумма, которая списывается
            double totalDebit = amountInBase + commission;
            if (balance >= totalDebit)
            {
                balance -= totalDebit;
                return true;
            }
            return false;
        }
        // Получить баланс счета, конвертированный в выбранную валюту
        public double GetBalanceInCurrency(Currency currency)
        {
            return balance / currency.Rate;
        }
    }
}

// Form1.Designer.cs

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // ========= Контролы для "Счет 1" =========
        private System.Windows.Forms.GroupBox groupBoxAccount1;
        private System.Windows.Forms.Label labelBalance1;
        private System.Windows.Forms.Label labelCurrentBalance1;
        private System.Windows.Forms.Label labelAccountCurrency1;
        private System.Windows.Forms.ComboBox comboBoxAccountCurrency1;
        private System.Windows.Forms.GroupBox groupBoxTransaction1;
        private System.Windows.Forms.Label labelTransactionAmount1;
        private System.Windows.Forms.TextBox textBoxTransactionAmount1;
        private System.Windows.Forms.Label labelTransactionCurrency1;
        private System.Windows.Forms.ComboBox comboBoxTransactionCurrency1;
        private System.Windows.Forms.Button buttonDeposit1;
        private System.Windows.Forms.Button buttonWithdraw1;
        // ========= Контролы для "Счет 2" =========
        private System.Windows.Forms.GroupBox groupBoxAccount2;
        private System.Windows.Forms.Label labelBalance2;
        private System.Windows.Forms.Label labelCurrentBalance2;
        private System.Windows.Forms.Label labelAccountCurrency2;
        private System.Windows.Forms.ComboBox comboBoxAccountCurrency2;
        private System.Windows.Forms.GroupBox groupBoxTransaction2;
        private System.Windows.Forms.Label labelTransactionAmount2;
        private System.Windows.Forms.TextBox textBoxTransactionAmount2;
        private System.Windows.Forms.Label labelTransactionCurrency2;
        private System.Windows.Forms.ComboBox comboBoxTransactionCurrency2;
        private System.Windows.Forms.Button buttonDeposit2;
        private System.Windows.Forms.Button buttonWithdraw2;
        // ========= Итоговая зона "На руках" =========
        private System.Windows.Forms.Label labelOnHands;
        private System.Windows.Forms.Label labelOnHandsValue;
        private System.Windows.Forms.ComboBox comboBoxOnHandsCurrency;
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
        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // -----------------------------------------------------------------
            // СЧЕТ 1
            // -----------------------------------------------------------------
            this.groupBoxAccount1 = new System.Windows.Forms.GroupBox();
            this.labelBalance1 = new System.Windows.Forms.Label();
            this.labelCurrentBalance1 = new System.Windows.Forms.Label();
            this.labelAccountCurrency1 = new System.Windows.Forms.Label();
            this.comboBoxAccountCurrency1 = new System.Windows.Forms.ComboBox();
            this.groupBoxTransaction1 = new System.Windows.Forms.GroupBox();
            this.labelTransactionAmount1 = new System.Windows.Forms.Label();
            this.textBoxTransactionAmount1 = new System.Windows.Forms.TextBox();
            this.labelTransactionCurrency1 = new System.Windows.Forms.Label();
            this.comboBoxTransactionCurrency1 = new
           System.Windows.Forms.ComboBox();
            this.buttonDeposit1 = new System.Windows.Forms.Button();
            this.buttonWithdraw1 = new System.Windows.Forms.Button();
            // -----------------------------------------------------------------
            // СЧЕТ 2
            // -----------------------------------------------------------------
            this.groupBoxAccount2 = new System.Windows.Forms.GroupBox();
            this.labelBalance2 = new System.Windows.Forms.Label();
            this.labelCurrentBalance2 = new System.Windows.Forms.Label();
            this.labelAccountCurrency2 = new System.Windows.Forms.Label();
            this.comboBoxAccountCurrency2 = new System.Windows.Forms.ComboBox();
            this.groupBoxTransaction2 = new System.Windows.Forms.GroupBox();
            this.labelTransactionAmount2 = new System.Windows.Forms.Label();
            this.textBoxTransactionAmount2 = new System.Windows.Forms.TextBox();
            this.labelTransactionCurrency2 = new System.Windows.Forms.Label();
            this.comboBoxTransactionCurrency2 = new
           System.Windows.Forms.ComboBox();
            this.buttonDeposit2 = new System.Windows.Forms.Button();
            this.buttonWithdraw2 = new System.Windows.Forms.Button();
            // -----------------------------------------------------------------
            // "НА РУКАХ"
            // -----------------------------------------------------------------
            this.labelOnHands = new System.Windows.Forms.Label();
            this.labelOnHandsValue = new System.Windows.Forms.Label();
            this.comboBoxOnHandsCurrency = new System.Windows.Forms.ComboBox();
            //
            // groupBoxAccount1
            //
            this.groupBoxAccount1.Controls.Add(this.comboBoxAccountCurrency1);
            this.groupBoxAccount1.Controls.Add(this.labelAccountCurrency1);
            this.groupBoxAccount1.Controls.Add(this.labelCurrentBalance1);
            this.groupBoxAccount1.Controls.Add(this.labelBalance1);
            this.groupBoxAccount1.Location = new System.Drawing.Point(20, 20);
            this.groupBoxAccount1.Name = "groupBoxAccount1";
            this.groupBoxAccount1.Size = new System.Drawing.Size(250, 100);
            this.groupBoxAccount1.TabIndex = 0;
            this.groupBoxAccount1.TabStop = false;
            this.groupBoxAccount1.Text = "Счет 1";
            //
            // labelBalance1
            //
            this.labelBalance1.AutoSize = true;
            this.labelBalance1.Location = new System.Drawing.Point(15, 25);
            this.labelBalance1.Name = "labelBalance1";
            this.labelBalance1.Size = new System.Drawing.Size(52, 13);
            this.labelBalance1.TabIndex = 0;
            this.labelBalance1.Text = "Баланс:";
            //
            // labelCurrentBalance1
            //
            this.labelCurrentBalance1.AutoSize = true;
            this.labelCurrentBalance1.Location = new System.Drawing.Point(80, 25);
            this.labelCurrentBalance1.Name = "labelCurrentBalance1";
            this.labelCurrentBalance1.Size = new System.Drawing.Size(28, 13);
            this.labelCurrentBalance1.TabIndex = 1;
            this.labelCurrentBalance1.Text = "0.00";
            //
            // labelAccountCurrency1
            //
            this.labelAccountCurrency1.AutoSize = true;
            this.labelAccountCurrency1.Location = new System.Drawing.Point(15,
           60);
            this.labelAccountCurrency1.Name = "labelAccountCurrency1";
            this.labelAccountCurrency1.Size = new System.Drawing.Size(52, 13);
            this.labelAccountCurrency1.TabIndex = 2;
            this.labelAccountCurrency1.Text = "Валюта:";
            //
            // comboBoxAccountCurrency1
            //
            this.comboBoxAccountCurrency1.DropDownStyle =
           System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountCurrency1.FormattingEnabled = true;
            this.comboBoxAccountCurrency1.Location = new System.Drawing.Point(80,
           57);
            this.comboBoxAccountCurrency1.Name = "comboBoxAccountCurrency1";
            this.comboBoxAccountCurrency1.Size = new System.Drawing.Size(120, 21);
            this.comboBoxAccountCurrency1.TabIndex = 3;
            this.comboBoxAccountCurrency1.SelectedIndexChanged += new
           System.EventHandler(this.comboBoxAccountCurrency1_SelectedIndexChanged);
            //
            // groupBoxTransaction1
            //
            this.groupBoxTransaction1.Controls.Add(this.buttonWithdraw1);
            this.groupBoxTransaction1.Controls.Add(this.buttonDeposit1);

            this.groupBoxTransaction1.Controls.Add(this.comboBoxTransactionCurrency1);

            this.groupBoxTransaction1.Controls.Add(this.labelTransactionCurrency1);

            this.groupBoxTransaction1.Controls.Add(this.textBoxTransactionAmount1);
            this.groupBoxTransaction1.Controls.Add(this.labelTransactionAmount1);
            this.groupBoxTransaction1.Location = new System.Drawing.Point(20,
           140);
            this.groupBoxTransaction1.Name = "groupBoxTransaction1";
            this.groupBoxTransaction1.Size = new System.Drawing.Size(250, 120);
            this.groupBoxTransaction1.TabIndex = 1;
            this.groupBoxTransaction1.TabStop = false;
            this.groupBoxTransaction1.Text = "Транзакция (Счет 1)";
            //
            // labelTransactionAmount1
            //
            this.labelTransactionAmount1.AutoSize = true;
            this.labelTransactionAmount1.Location = new System.Drawing.Point(15,
           30);
            this.labelTransactionAmount1.Name = "labelTransactionAmount1";
            this.labelTransactionAmount1.Size = new System.Drawing.Size(46, 13);
            this.labelTransactionAmount1.TabIndex = 0;
            this.labelTransactionAmount1.Text = "Сумма:";
            //
            // textBoxTransactionAmount1
            //
            this.textBoxTransactionAmount1.Location = new System.Drawing.Point(80,
           27);
            this.textBoxTransactionAmount1.Name = "textBoxTransactionAmount1";
            this.textBoxTransactionAmount1.Size = new System.Drawing.Size(100,
           20);
            this.textBoxTransactionAmount1.TabIndex = 1;
            //
            // labelTransactionCurrency1
            //
            this.labelTransactionCurrency1.AutoSize = true;
            this.labelTransactionCurrency1.Location = new System.Drawing.Point(15,
           60);
            this.labelTransactionCurrency1.Name = "labelTransactionCurrency1";
            this.labelTransactionCurrency1.Size = new System.Drawing.Size(52, 13);
            this.labelTransactionCurrency1.TabIndex = 2;
            this.labelTransactionCurrency1.Text = "Валюта:";
            //
            // comboBoxTransactionCurrency1
            //
            this.comboBoxTransactionCurrency1.DropDownStyle =
           System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransactionCurrency1.FormattingEnabled = true;
            this.comboBoxTransactionCurrency1.Location = new
           System.Drawing.Point(80, 57);
            this.comboBoxTransactionCurrency1.Name =
           "comboBoxTransactionCurrency1";
            this.comboBoxTransactionCurrency1.Size = new System.Drawing.Size(100,
           21);
            this.comboBoxTransactionCurrency1.TabIndex = 3;
            //
            // buttonDeposit1
            //
            this.buttonDeposit1.Location = new System.Drawing.Point(15, 85);
            this.buttonDeposit1.Name = "buttonDeposit1";
            this.buttonDeposit1.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposit1.TabIndex = 4;
            this.buttonDeposit1.Text = "Зачислить";
            this.buttonDeposit1.UseVisualStyleBackColor = true;
            this.buttonDeposit1.Click += new
           System.EventHandler(this.buttonDeposit1_Click);
            //
            // buttonWithdraw1
            //
            this.buttonWithdraw1.Location = new System.Drawing.Point(105, 85);
            this.buttonWithdraw1.Name = "buttonWithdraw1";
            this.buttonWithdraw1.Size = new System.Drawing.Size(75, 23);
            this.buttonWithdraw1.TabIndex = 5;
            this.buttonWithdraw1.Text = "Снять";
            this.buttonWithdraw1.UseVisualStyleBackColor = true;
            this.buttonWithdraw1.Click += new
           System.EventHandler(this.buttonWithdraw1_Click);
            // -----------------------------------------------------------------
            // СЧЕТ 2
            // -----------------------------------------------------------------
            this.groupBoxAccount2.Controls.Add(this.comboBoxAccountCurrency2);
            this.groupBoxAccount2.Controls.Add(this.labelAccountCurrency2);
            this.groupBoxAccount2.Controls.Add(this.labelCurrentBalance2);
            this.groupBoxAccount2.Controls.Add(this.labelBalance2);
            this.groupBoxAccount2.Location = new System.Drawing.Point(320, 20);
            this.groupBoxAccount2.Name = "groupBoxAccount2";
            this.groupBoxAccount2.Size = new System.Drawing.Size(250, 100);
            this.groupBoxAccount2.TabIndex = 2;
            this.groupBoxAccount2.TabStop = false;
            this.groupBoxAccount2.Text = "Счет 2";
            //
            // labelBalance2
            //
            this.labelBalance2.AutoSize = true;
            this.labelBalance2.Location = new System.Drawing.Point(15, 25);
            this.labelBalance2.Name = "labelBalance2";
            this.labelBalance2.Size = new System.Drawing.Size(52, 13);
            this.labelBalance2.TabIndex = 0;
            this.labelBalance2.Text = "Баланс:";
            //
            // labelCurrentBalance2
            //
            this.labelCurrentBalance2.AutoSize = true;
            this.labelCurrentBalance2.Location = new System.Drawing.Point(80, 25);
            this.labelCurrentBalance2.Name = "labelCurrentBalance2";
            this.labelCurrentBalance2.Size = new System.Drawing.Size(28, 13);
            this.labelCurrentBalance2.TabIndex = 1;
            this.labelCurrentBalance2.Text = "0.00";
            //
            // labelAccountCurrency2
            //
            this.labelAccountCurrency2.AutoSize = true;
            this.labelAccountCurrency2.Location = new System.Drawing.Point(15,
           60);
            this.labelAccountCurrency2.Name = "labelAccountCurrency2";
            this.labelAccountCurrency2.Size = new System.Drawing.Size(52, 13);
            this.labelAccountCurrency2.TabIndex = 2;
            this.labelAccountCurrency2.Text = "Валюта:";
            //
            // comboBoxAccountCurrency2
            //
            this.comboBoxAccountCurrency2.DropDownStyle =
           System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountCurrency2.FormattingEnabled = true;
            this.comboBoxAccountCurrency2.Location = new System.Drawing.Point(80,
           57);
            this.comboBoxAccountCurrency2.Name = "comboBoxAccountCurrency2";
            this.comboBoxAccountCurrency2.Size = new System.Drawing.Size(120, 21);
            this.comboBoxAccountCurrency2.TabIndex = 3;
            this.comboBoxAccountCurrency2.SelectedIndexChanged += new
           System.EventHandler(this.comboBoxAccountCurrency2_SelectedIndexChanged);
            //
            // groupBoxTransaction2
            //
            this.groupBoxTransaction2.Controls.Add(this.buttonWithdraw2);
            this.groupBoxTransaction2.Controls.Add(this.buttonDeposit2);

            this.groupBoxTransaction2.Controls.Add(this.comboBoxTransactionCurrency2);

            this.groupBoxTransaction2.Controls.Add(this.labelTransactionCurrency2);

            this.groupBoxTransaction2.Controls.Add(this.textBoxTransactionAmount2);
            this.groupBoxTransaction2.Controls.Add(this.labelTransactionAmount2);
            this.groupBoxTransaction2.Location = new System.Drawing.Point(320,
           140);
            this.groupBoxTransaction2.Name = "groupBoxTransaction2";
            this.groupBoxTransaction2.Size = new System.Drawing.Size(250, 120);
            this.groupBoxTransaction2.TabIndex = 3;
            this.groupBoxTransaction2.TabStop = false;
            this.groupBoxTransaction2.Text = "Транзакция (Счет 2)";
            //
            // labelTransactionAmount2
            //
            this.labelTransactionAmount2.AutoSize = true;
            this.labelTransactionAmount2.Location = new System.Drawing.Point(15,
           30);
            this.labelTransactionAmount2.Name = "labelTransactionAmount2";
            this.labelTransactionAmount2.Size = new System.Drawing.Size(46, 13);
            this.labelTransactionAmount2.TabIndex = 0;
            this.labelTransactionAmount2.Text = "Сумма:";
            //
            // textBoxTransactionAmount2
            //
            this.textBoxTransactionAmount2.Location = new System.Drawing.Point(80,
           27);
            this.textBoxTransactionAmount2.Name = "textBoxTransactionAmount2";
            this.textBoxTransactionAmount2.Size = new System.Drawing.Size(100,
           20);
            this.textBoxTransactionAmount2.TabIndex = 1;
            //
            // labelTransactionCurrency2
            //
            this.labelTransactionCurrency2.AutoSize = true;
            this.labelTransactionCurrency2.Location = new System.Drawing.Point(15,
           60);
            this.labelTransactionCurrency2.Name = "labelTransactionCurrency2";
            this.labelTransactionCurrency2.Size = new System.Drawing.Size(52, 13);
            this.labelTransactionCurrency2.TabIndex = 2;
            this.labelTransactionCurrency2.Text = "Валюта:";
            //
            // comboBoxTransactionCurrency2
            //
            this.comboBoxTransactionCurrency2.DropDownStyle =
           System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransactionCurrency2.FormattingEnabled = true;
            this.comboBoxTransactionCurrency2.Location = new
           System.Drawing.Point(80, 57);
            this.comboBoxTransactionCurrency2.Name =
           "comboBoxTransactionCurrency2";
            this.comboBoxTransactionCurrency2.Size = new System.Drawing.Size(100,
           21);
            this.comboBoxTransactionCurrency2.TabIndex = 3;
            //
            // buttonDeposit2
            //
            this.buttonDeposit2.Location = new System.Drawing.Point(15, 85);
            this.buttonDeposit2.Name = "buttonDeposit2";
            this.buttonDeposit2.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposit2.TabIndex = 4;
            this.buttonDeposit2.Text = "Зачислить";
            this.buttonDeposit2.UseVisualStyleBackColor = true;
            this.buttonDeposit2.Click += new
           System.EventHandler(this.buttonDeposit2_Click);
            //
            // buttonWithdraw2
            //
            this.buttonWithdraw2.Location = new System.Drawing.Point(105, 85);
            this.buttonWithdraw2.Name = "buttonWithdraw2";
            this.buttonWithdraw2.Size = new System.Drawing.Size(75, 23);
            this.buttonWithdraw2.TabIndex = 5;
            this.buttonWithdraw2.Text = "Снять";
            this.buttonWithdraw2.UseVisualStyleBackColor = true;
            this.buttonWithdraw2.Click += new
           System.EventHandler(this.buttonWithdraw2_Click);
            //
            // labelOnHands
            //
            this.labelOnHands.AutoSize = true;
            this.labelOnHands.Location = new System.Drawing.Point(20, 280);
            this.labelOnHands.Name = "labelOnHands";
            this.labelOnHands.Size = new System.Drawing.Size(55, 13);
            this.labelOnHands.TabIndex = 4;
            this.labelOnHands.Text = "На руках:";
            //
            // labelOnHandsValue
            //
            this.labelOnHandsValue.AutoSize = true;
            this.labelOnHandsValue.Location = new System.Drawing.Point(80, 280);
            this.labelOnHandsValue.Name = "labelOnHandsValue";
            this.labelOnHandsValue.Size = new System.Drawing.Size(28, 13);
            this.labelOnHandsValue.TabIndex = 5;
            this.labelOnHandsValue.Text = "0.00";
            //
            // comboBoxOnHandsCurrency
            //
            this.comboBoxOnHandsCurrency.DropDownStyle =
           System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOnHandsCurrency.FormattingEnabled = true;
            this.comboBoxOnHandsCurrency.Location = new System.Drawing.Point(130,
           277);
            this.comboBoxOnHandsCurrency.Name = "comboBoxOnHandsCurrency";
            this.comboBoxOnHandsCurrency.Size = new System.Drawing.Size(80, 21);
            this.comboBoxOnHandsCurrency.TabIndex = 6;
            this.comboBoxOnHandsCurrency.SelectedIndexChanged += new
           System.EventHandler(this.comboBoxOnHandsCurrency_SelectedIndexChanged);
            //
            // Form1
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // Увеличим размер окна для наглядности
            this.ClientSize = new System.Drawing.Size(600, 330);
            this.Controls.Add(this.comboBoxOnHandsCurrency);
            this.Controls.Add(this.labelOnHandsValue);
            this.Controls.Add(this.labelOnHands);
            this.Controls.Add(this.groupBoxTransaction2);
            this.Controls.Add(this.groupBoxAccount2);
            this.Controls.Add(this.groupBoxTransaction1);
            this.Controls.Add(this.groupBoxAccount1);
            this.Name = "Form1";
            this.Text = "Банковские счета";
            this.groupBoxAccount1.ResumeLayout(false);
            this.groupBoxAccount1.PerformLayout();
            this.groupBoxTransaction1.ResumeLayout(false);
            this.groupBoxTransaction1.PerformLayout();
            this.groupBoxAccount2.ResumeLayout(false);
            this.groupBoxAccount2.PerformLayout();
            this.groupBoxTransaction2.ResumeLayout(false);
            this.groupBoxTransaction2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}

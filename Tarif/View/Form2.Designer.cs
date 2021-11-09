
namespace Tarif
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
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelGygabytes = new System.Windows.Forms.Label();
            this.textBoxGygabytes = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.listBoxTariffs = new System.Windows.Forms.ListBox();
            this.labelMessages = new System.Windows.Forms.Label();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.checkBoxAD = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonBuyTariff = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxOutcome = new System.Windows.Forms.ListBox();
            this.labelNamePA = new System.Windows.Forms.Label();
            this.labelSecondNamePA = new System.Windows.Forms.Label();
            this.labelBirthdayPA = new System.Windows.Forms.Label();
            this.labelPhoneNumberPA = new System.Windows.Forms.Label();
            this.labelTariffPA = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelOutcome = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.listBoxIncome = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labelSumIncome = new System.Windows.Forms.Label();
            this.textBoxSumIncome = new System.Windows.Forms.TextBox();
            this.checkBoxOk = new System.Windows.Forms.CheckBox();
            this.buttonFill = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(179, 104);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(46, 13);
            this.labelMinutes.TabIndex = 3;
            this.labelMinutes.Text = "Минуты";
            // 
            // labelGygabytes
            // 
            this.labelGygabytes.AutoSize = true;
            this.labelGygabytes.Location = new System.Drawing.Point(164, 80);
            this.labelGygabytes.Name = "labelGygabytes";
            this.labelGygabytes.Size = new System.Drawing.Size(61, 13);
            this.labelGygabytes.TabIndex = 4;
            this.labelGygabytes.Text = "Гигобайты";
            // 
            // textBoxGygabytes
            // 
            this.textBoxGygabytes.Location = new System.Drawing.Point(231, 75);
            this.textBoxGygabytes.Name = "textBoxGygabytes";
            this.textBoxGygabytes.ReadOnly = true;
            this.textBoxGygabytes.Size = new System.Drawing.Size(100, 20);
            this.textBoxGygabytes.TabIndex = 5;
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(231, 101);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.ReadOnly = true;
            this.textBoxMinutes.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinutes.TabIndex = 6;
            // 
            // listBoxTariffs
            // 
            this.listBoxTariffs.FormattingEnabled = true;
            this.listBoxTariffs.Location = new System.Drawing.Point(12, 68);
            this.listBoxTariffs.Name = "listBoxTariffs";
            this.listBoxTariffs.Size = new System.Drawing.Size(146, 238);
            this.listBoxTariffs.TabIndex = 8;
            this.listBoxTariffs.SelectedIndexChanged += new System.EventHandler(this.listBoxTariffs_SelectedIndexChanged);
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Location = new System.Drawing.Point(160, 130);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(65, 13);
            this.labelMessages.TabIndex = 10;
            this.labelMessages.Text = "Сообщения";
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(231, 127);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(100, 20);
            this.textBoxMessages.TabIndex = 11;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(192, 156);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(231, 153);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-4, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 380);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.labelPassword);
            this.tabPage1.Controls.Add(this.labelBirthday);
            this.tabPage1.Controls.Add(this.labelPhoneNumber);
            this.tabPage1.Controls.Add(this.labelSecondName);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.buttonRegister);
            this.tabPage1.Controls.Add(this.checkBoxAD);
            this.tabPage1.Controls.Add(this.textBoxPassword);
            this.tabPage1.Controls.Add(this.textBoxPhoneNumber);
            this.tabPage1.Controls.Add(this.textBoxBirthday);
            this.tabPage1.Controls.Add(this.textBoxSecondName);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Регистрация";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(16, 140);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Пароль";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(6, 91);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(78, 13);
            this.labelBirthday.TabIndex = 11;
            this.labelBirthday.Text = "Год рождения";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(1, 114);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumber.TabIndex = 10;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(9, 58);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelSecondName.TabIndex = 8;
            this.labelSecondName.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Имя";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Enabled = false;
            this.buttonRegister.Location = new System.Drawing.Point(2, 200);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(817, 146);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // checkBoxAD
            // 
            this.checkBoxAD.AutoSize = true;
            this.checkBoxAD.Location = new System.Drawing.Point(381, 166);
            this.checkBoxAD.Name = "checkBoxAD";
            this.checkBoxAD.Size = new System.Drawing.Size(132, 17);
            this.checkBoxAD.TabIndex = 5;
            this.checkBoxAD.Text = "Принимаю рассылку";
            this.checkBoxAD.UseVisualStyleBackColor = true;
            this.checkBoxAD.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(71, 137);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(736, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(100, 111);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(707, 20);
            this.textBoxPhoneNumber.TabIndex = 3;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(90, 88);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(718, 20);
            this.textBoxBirthday.TabIndex = 2;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(71, 55);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(736, 20);
            this.textBoxSecondName.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(67, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(740, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelTariffPA);
            this.tabPage2.Controls.Add(this.labelPhoneNumberPA);
            this.tabPage2.Controls.Add(this.labelBirthdayPA);
            this.tabPage2.Controls.Add(this.labelSecondNamePA);
            this.tabPage2.Controls.Add(this.labelNamePA);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Личный кабинет";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(181, 150);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(181, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonBuyTariff);
            this.tabPage3.Controls.Add(this.listBoxTariffs);
            this.tabPage3.Controls.Add(this.textBoxPrice);
            this.tabPage3.Controls.Add(this.labelGygabytes);
            this.tabPage3.Controls.Add(this.labelPrice);
            this.tabPage3.Controls.Add(this.textBoxGygabytes);
            this.tabPage3.Controls.Add(this.labelMessages);
            this.tabPage3.Controls.Add(this.textBoxMessages);
            this.tabPage3.Controls.Add(this.textBoxMinutes);
            this.tabPage3.Controls.Add(this.labelMinutes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(818, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тарифы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonBuyTariff
            // 
            this.buttonBuyTariff.Location = new System.Drawing.Point(195, 207);
            this.buttonBuyTariff.Name = "buttonBuyTariff";
            this.buttonBuyTariff.Size = new System.Drawing.Size(365, 23);
            this.buttonBuyTariff.TabIndex = 14;
            this.buttonBuyTariff.Text = "Купить тариф";
            this.buttonBuyTariff.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxIncome);
            this.tabPage4.Controls.Add(this.labelIncome);
            this.tabPage4.Controls.Add(this.labelOutcome);
            this.tabPage4.Controls.Add(this.labelBalance);
            this.tabPage4.Controls.Add(this.textBoxBalance);
            this.tabPage4.Controls.Add(this.listBoxOutcome);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(818, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Баланс";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxOutcome
            // 
            this.listBoxOutcome.FormattingEnabled = true;
            this.listBoxOutcome.Location = new System.Drawing.Point(116, 104);
            this.listBoxOutcome.Name = "listBoxOutcome";
            this.listBoxOutcome.Size = new System.Drawing.Size(178, 186);
            this.listBoxOutcome.TabIndex = 0;
            // 
            // labelNamePA
            // 
            this.labelNamePA.AutoSize = true;
            this.labelNamePA.Location = new System.Drawing.Point(146, 44);
            this.labelNamePA.Name = "labelNamePA";
            this.labelNamePA.Size = new System.Drawing.Size(29, 13);
            this.labelNamePA.TabIndex = 8;
            this.labelNamePA.Text = "Имя";
            // 
            // labelSecondNamePA
            // 
            this.labelSecondNamePA.AutoSize = true;
            this.labelSecondNamePA.Location = new System.Drawing.Point(119, 70);
            this.labelSecondNamePA.Name = "labelSecondNamePA";
            this.labelSecondNamePA.Size = new System.Drawing.Size(56, 13);
            this.labelSecondNamePA.TabIndex = 9;
            this.labelSecondNamePA.Text = "Фамилия";
            // 
            // labelBirthdayPA
            // 
            this.labelBirthdayPA.AutoSize = true;
            this.labelBirthdayPA.Location = new System.Drawing.Point(97, 93);
            this.labelBirthdayPA.Name = "labelBirthdayPA";
            this.labelBirthdayPA.Size = new System.Drawing.Size(78, 13);
            this.labelBirthdayPA.TabIndex = 12;
            this.labelBirthdayPA.Text = "Год рождения";
            // 
            // labelPhoneNumberPA
            // 
            this.labelPhoneNumberPA.AutoSize = true;
            this.labelPhoneNumberPA.Location = new System.Drawing.Point(82, 117);
            this.labelPhoneNumberPA.Name = "labelPhoneNumberPA";
            this.labelPhoneNumberPA.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumberPA.TabIndex = 13;
            this.labelPhoneNumberPA.Text = "Номер телефона";
            // 
            // labelTariffPA
            // 
            this.labelTariffPA.AutoSize = true;
            this.labelTariffPA.Location = new System.Drawing.Point(135, 150);
            this.labelTariffPA.Name = "labelTariffPA";
            this.labelTariffPA.Size = new System.Drawing.Size(40, 13);
            this.labelTariffPA.TabIndex = 14;
            this.labelTariffPA.Text = "Тариф";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(346, 40);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.textBoxBalance.TabIndex = 1;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(376, 21);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(44, 13);
            this.labelBalance.TabIndex = 2;
            this.labelBalance.Text = "Баланс";
            // 
            // labelOutcome
            // 
            this.labelOutcome.AutoSize = true;
            this.labelOutcome.Location = new System.Drawing.Point(183, 88);
            this.labelOutcome.Name = "labelOutcome";
            this.labelOutcome.Size = new System.Drawing.Size(39, 13);
            this.labelOutcome.TabIndex = 3;
            this.labelOutcome.Text = "Траты";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(544, 88);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(69, 13);
            this.labelIncome.TabIndex = 4;
            this.labelIncome.Text = "Пополнения";
            // 
            // listBoxIncome
            // 
            this.listBoxIncome.FormattingEnabled = true;
            this.listBoxIncome.Location = new System.Drawing.Point(496, 104);
            this.listBoxIncome.Name = "listBoxIncome";
            this.listBoxIncome.Size = new System.Drawing.Size(178, 186);
            this.listBoxIncome.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonFill);
            this.tabPage5.Controls.Add(this.checkBoxOk);
            this.tabPage5.Controls.Add(this.textBoxSumIncome);
            this.tabPage5.Controls.Add(this.labelSumIncome);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(818, 354);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Пополнить баланс";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // labelSumIncome
            // 
            this.labelSumIncome.AutoSize = true;
            this.labelSumIncome.Location = new System.Drawing.Point(190, 39);
            this.labelSumIncome.Name = "labelSumIncome";
            this.labelSumIncome.Size = new System.Drawing.Size(104, 13);
            this.labelSumIncome.TabIndex = 0;
            this.labelSumIncome.Text = "Сумма пополнения";
            // 
            // textBoxSumIncome
            // 
            this.textBoxSumIncome.Location = new System.Drawing.Point(193, 56);
            this.textBoxSumIncome.Name = "textBoxSumIncome";
            this.textBoxSumIncome.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumIncome.TabIndex = 1;
            // 
            // checkBoxOk
            // 
            this.checkBoxOk.AutoSize = true;
            this.checkBoxOk.Location = new System.Drawing.Point(193, 82);
            this.checkBoxOk.Name = "checkBoxOk";
            this.checkBoxOk.Size = new System.Drawing.Size(107, 17);
            this.checkBoxOk.TabIndex = 2;
            this.checkBoxOk.Text = "Подтверждение";
            this.checkBoxOk.UseVisualStyleBackColor = true;
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(205, 105);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(75, 23);
            this.buttonFill.TabIndex = 3;
            this.buttonFill.Text = "Пополнить";
            this.buttonFill.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 376);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelGygabytes;
        private System.Windows.Forms.TextBox textBoxGygabytes;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.ListBox listBoxTariffs;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.CheckBox checkBoxAD;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuyTariff;
        private System.Windows.Forms.ListBox listBoxOutcome;
        private System.Windows.Forms.Label labelTariffPA;
        private System.Windows.Forms.Label labelPhoneNumberPA;
        private System.Windows.Forms.Label labelBirthdayPA;
        private System.Windows.Forms.Label labelSecondNamePA;
        private System.Windows.Forms.Label labelNamePA;
        private System.Windows.Forms.ListBox listBoxIncome;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelOutcome;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox checkBoxOk;
        private System.Windows.Forms.TextBox textBoxSumIncome;
        private System.Windows.Forms.Label labelSumIncome;
        private System.Windows.Forms.Button buttonFill;
    }
}


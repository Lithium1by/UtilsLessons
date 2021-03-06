﻿namespace MyUtils
{
    partial class frmUtils
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
            this.msUp = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbpControl = new System.Windows.Forms.TabControl();
            this.tbpConv = new System.Windows.Forms.TabPage();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.tbpPass = new System.Windows.Forms.TabPage();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnPassGreate = new System.Windows.Forms.Button();
            this.lblPassLength = new System.Windows.Forms.Label();
            this.nudPassLength = new System.Windows.Forms.NumericUpDown();
            this.clbPassProp = new System.Windows.Forms.CheckedListBox();
            this.tbpNote = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tbpRandom = new System.Windows.Forms.TabPage();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnRandomListCopy = new System.Windows.Forms.Button();
            this.btnRandomListClear = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.lblRandomResult = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tbpCounter = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCountMinus = new System.Windows.Forms.Button();
            this.btnCountPlus = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.cbMetrica = new System.Windows.Forms.ComboBox();
            this.msUp.SuspendLayout();
            this.tbpControl.SuspendLayout();
            this.tbpConv.SuspendLayout();
            this.tbpPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).BeginInit();
            this.tbpNote.SuspendLayout();
            this.tbpRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            this.tbpCounter.SuspendLayout();
            this.SuspendLayout();
            // 
            // msUp
            // 
            this.msUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.блокнотToolStripMenuItem,
            this.tsmiHelp});
            this.msUp.Location = new System.Drawing.Point(0, 0);
            this.msUp.Name = "msUp";
            this.msUp.Size = new System.Drawing.Size(284, 24);
            this.msUp.TabIndex = 0;
            this.msUp.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(108, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(232, 22);
            this.tsmiInsertDate.Text = "Вставить дату";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiInsertTime
            // 
            this.tsmiInsertTime.Name = "tsmiInsertTime";
            this.tsmiInsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsertTime.Size = new System.Drawing.Size(232, 22);
            this.tsmiInsertTime.Text = "Вставить время";
            this.tsmiInsertTime.Click += new System.EventHandler(this.tsmiInsertTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(232, 22);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.tsmiLoad.Size = new System.Drawing.Size(232, 22);
            this.tsmiLoad.Text = "Загрузить";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(68, 20);
            this.tsmiHelp.Text = "Помощь";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(149, 22);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tbpControl
            // 
            this.tbpControl.Controls.Add(this.tbpConv);
            this.tbpControl.Controls.Add(this.tbpPass);
            this.tbpControl.Controls.Add(this.tbpNote);
            this.tbpControl.Controls.Add(this.tbpRandom);
            this.tbpControl.Controls.Add(this.tbpCounter);
            this.tbpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpControl.Location = new System.Drawing.Point(0, 24);
            this.tbpControl.Name = "tbpControl";
            this.tbpControl.SelectedIndex = 0;
            this.tbpControl.Size = new System.Drawing.Size(284, 237);
            this.tbpControl.TabIndex = 1;
            // 
            // tbpConv
            // 
            this.tbpConv.Controls.Add(this.cbMetrica);
            this.tbpConv.Controls.Add(this.btnSwap);
            this.tbpConv.Controls.Add(this.tbTo);
            this.tbpConv.Controls.Add(this.tbFrom);
            this.tbpConv.Controls.Add(this.btnConvert);
            this.tbpConv.Controls.Add(this.cbTo);
            this.tbpConv.Controls.Add(this.cbFrom);
            this.tbpConv.Location = new System.Drawing.Point(4, 22);
            this.tbpConv.Name = "tbpConv";
            this.tbpConv.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConv.Size = new System.Drawing.Size(276, 211);
            this.tbpConv.TabIndex = 4;
            this.tbpConv.Text = "Конвертер";
            this.tbpConv.UseVisualStyleBackColor = true;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(189, 88);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(79, 20);
            this.tbTo.TabIndex = 4;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(8, 88);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(87, 20);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "1";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(101, 88);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Конверт";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "мили"});
            this.cbTo.Location = new System.Drawing.Point(189, 61);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(79, 21);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "мм";
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "мили"});
            this.cbFrom.Location = new System.Drawing.Point(6, 61);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(89, 21);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "мм";
            // 
            // tbpPass
            // 
            this.tbpPass.Controls.Add(this.tbPassword);
            this.tbpPass.Controls.Add(this.btnPassGreate);
            this.tbpPass.Controls.Add(this.lblPassLength);
            this.tbpPass.Controls.Add(this.nudPassLength);
            this.tbpPass.Controls.Add(this.clbPassProp);
            this.tbpPass.Location = new System.Drawing.Point(4, 22);
            this.tbpPass.Name = "tbpPass";
            this.tbpPass.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPass.Size = new System.Drawing.Size(276, 211);
            this.tbpPass.TabIndex = 3;
            this.tbpPass.Text = "Пороли";
            this.tbpPass.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(7, 160);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(205, 19);
            this.tbPassword.TabIndex = 4;
            // 
            // btnPassGreate
            // 
            this.btnPassGreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPassGreate.Location = new System.Drawing.Point(8, 121);
            this.btnPassGreate.Name = "btnPassGreate";
            this.btnPassGreate.Size = new System.Drawing.Size(156, 32);
            this.btnPassGreate.TabIndex = 3;
            this.btnPassGreate.Text = "Создать пароль";
            this.btnPassGreate.UseVisualStyleBackColor = true;
            this.btnPassGreate.Click += new System.EventHandler(this.btnPassGreate_Click);
            // 
            // lblPassLength
            // 
            this.lblPassLength.AutoSize = true;
            this.lblPassLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassLength.Location = new System.Drawing.Point(8, 91);
            this.lblPassLength.Name = "lblPassLength";
            this.lblPassLength.Size = new System.Drawing.Size(121, 20);
            this.lblPassLength.TabIndex = 2;
            this.lblPassLength.Text = "Длина пароля:";
            // 
            // nudPassLength
            // 
            this.nudPassLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPassLength.Location = new System.Drawing.Point(135, 89);
            this.nudPassLength.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudPassLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPassLength.Name = "nudPassLength";
            this.nudPassLength.Size = new System.Drawing.Size(69, 26);
            this.nudPassLength.TabIndex = 1;
            this.nudPassLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // clbPassProp
            // 
            this.clbPassProp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPassProp.CheckOnClick = true;
            this.clbPassProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbPassProp.FormattingEnabled = true;
            this.clbPassProp.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы: #, %, ^, & ,* , ("});
            this.clbPassProp.Location = new System.Drawing.Point(8, 3);
            this.clbPassProp.Name = "clbPassProp";
            this.clbPassProp.Size = new System.Drawing.Size(242, 85);
            this.clbPassProp.TabIndex = 0;
            // 
            // tbpNote
            // 
            this.tbpNote.Controls.Add(this.rtbNotepad);
            this.tbpNote.Location = new System.Drawing.Point(4, 22);
            this.tbpNote.Name = "tbpNote";
            this.tbpNote.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNote.Size = new System.Drawing.Size(276, 211);
            this.tbpNote.TabIndex = 2;
            this.tbpNote.Text = "Блокнот";
            this.tbpNote.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(3, 3);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(270, 205);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // tbpRandom
            // 
            this.tbpRandom.Controls.Add(this.cbRandom);
            this.tbpRandom.Controls.Add(this.btnRandomListCopy);
            this.tbpRandom.Controls.Add(this.btnRandomListClear);
            this.tbpRandom.Controls.Add(this.tbRandom);
            this.tbpRandom.Controls.Add(this.lblTo);
            this.tbpRandom.Controls.Add(this.lblFrom);
            this.tbpRandom.Controls.Add(this.nudTo);
            this.tbpRandom.Controls.Add(this.nudFrom);
            this.tbpRandom.Controls.Add(this.lblRandomResult);
            this.tbpRandom.Controls.Add(this.btnRandom);
            this.tbpRandom.Location = new System.Drawing.Point(4, 22);
            this.tbpRandom.Name = "tbpRandom";
            this.tbpRandom.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRandom.Size = new System.Drawing.Size(276, 211);
            this.tbpRandom.TabIndex = 1;
            this.tbpRandom.Text = "Генератор";
            this.tbpRandom.UseVisualStyleBackColor = true;
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRandom.Location = new System.Drawing.Point(9, 105);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(134, 20);
            this.cbRandom.TabIndex = 9;
            this.cbRandom.Text = "Без повторений";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // btnRandomListCopy
            // 
            this.btnRandomListCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandomListCopy.Location = new System.Drawing.Point(3, 171);
            this.btnRandomListCopy.Name = "btnRandomListCopy";
            this.btnRandomListCopy.Size = new System.Drawing.Size(188, 37);
            this.btnRandomListCopy.TabIndex = 8;
            this.btnRandomListCopy.Text = "Копировать";
            this.btnRandomListCopy.UseVisualStyleBackColor = true;
            this.btnRandomListCopy.Click += new System.EventHandler(this.btnRandomListCopy_Click);
            // 
            // btnRandomListClear
            // 
            this.btnRandomListClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandomListClear.Location = new System.Drawing.Point(3, 128);
            this.btnRandomListClear.Name = "btnRandomListClear";
            this.btnRandomListClear.Size = new System.Drawing.Size(188, 37);
            this.btnRandomListClear.TabIndex = 7;
            this.btnRandomListClear.Text = "Очистка";
            this.btnRandomListClear.UseVisualStyleBackColor = true;
            this.btnRandomListClear.Click += new System.EventHandler(this.btnRandomListClear_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRandom.Location = new System.Drawing.Point(214, 57);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(54, 146);
            this.tbRandom.TabIndex = 6;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTo.Location = new System.Drawing.Point(3, 57);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(52, 31);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "До";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(3, 13);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(49, 31);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "От";
            // 
            // nudTo
            // 
            this.nudTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTo.Location = new System.Drawing.Point(61, 57);
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(81, 38);
            this.nudTo.TabIndex = 3;
            this.nudTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTo.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nudFrom
            // 
            this.nudFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudFrom.Location = new System.Drawing.Point(61, 13);
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(81, 38);
            this.nudFrom.TabIndex = 2;
            this.nudFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRandomResult
            // 
            this.lblRandomResult.AutoSize = true;
            this.lblRandomResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandomResult.Location = new System.Drawing.Point(148, 54);
            this.lblRandomResult.Name = "lblRandomResult";
            this.lblRandomResult.Size = new System.Drawing.Size(43, 46);
            this.lblRandomResult.TabIndex = 1;
            this.lblRandomResult.Text = "0";
            this.lblRandomResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandom.Location = new System.Drawing.Point(148, 13);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(120, 38);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Задать";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tbpCounter
            // 
            this.tbpCounter.Controls.Add(this.lblCount);
            this.tbpCounter.Controls.Add(this.btnReset);
            this.tbpCounter.Controls.Add(this.btnCountMinus);
            this.tbpCounter.Controls.Add(this.btnCountPlus);
            this.tbpCounter.Location = new System.Drawing.Point(4, 22);
            this.tbpCounter.Name = "tbpCounter";
            this.tbpCounter.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCounter.Size = new System.Drawing.Size(276, 211);
            this.tbpCounter.TabIndex = 0;
            this.tbpCounter.Text = "Счетчик";
            this.tbpCounter.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(167, 20);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(69, 73);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(140, 119);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 84);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCountMinus
            // 
            this.btnCountMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCountMinus.Location = new System.Drawing.Point(8, 119);
            this.btnCountMinus.Name = "btnCountMinus";
            this.btnCountMinus.Size = new System.Drawing.Size(116, 84);
            this.btnCountMinus.TabIndex = 1;
            this.btnCountMinus.Text = "-";
            this.btnCountMinus.UseVisualStyleBackColor = true;
            this.btnCountMinus.Click += new System.EventHandler(this.btnCountMinus_Click);
            // 
            // btnCountPlus
            // 
            this.btnCountPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCountPlus.Location = new System.Drawing.Point(8, 6);
            this.btnCountPlus.Name = "btnCountPlus";
            this.btnCountPlus.Size = new System.Drawing.Size(116, 87);
            this.btnCountPlus.TabIndex = 0;
            this.btnCountPlus.Text = "+";
            this.btnCountPlus.UseVisualStyleBackColor = true;
            this.btnCountPlus.Click += new System.EventHandler(this.btnCountPlus_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(102, 61);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "<->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // cbMetrica
            // 
            this.cbMetrica.FormattingEnabled = true;
            this.cbMetrica.Items.AddRange(new object[] {
            "длина",
            "вес"});
            this.cbMetrica.Location = new System.Drawing.Point(102, 34);
            this.cbMetrica.Name = "cbMetrica";
            this.cbMetrica.Size = new System.Drawing.Size(75, 21);
            this.cbMetrica.TabIndex = 6;
            this.cbMetrica.Text = "длина";
            this.cbMetrica.SelectedIndexChanged += new System.EventHandler(this.cbMetrica_SelectedIndexChanged);
            // 
            // frmUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbpControl);
            this.Controls.Add(this.msUp);
            this.MainMenuStrip = this.msUp;
            this.Name = "frmUtils";
            this.Text = "Мои утилитки";
            this.Load += new System.EventHandler(this.frmUtils_Load);
            this.msUp.ResumeLayout(false);
            this.msUp.PerformLayout();
            this.tbpControl.ResumeLayout(false);
            this.tbpConv.ResumeLayout(false);
            this.tbpConv.PerformLayout();
            this.tbpPass.ResumeLayout(false);
            this.tbpPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).EndInit();
            this.tbpNote.ResumeLayout(false);
            this.tbpRandom.ResumeLayout(false);
            this.tbpRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            this.tbpCounter.ResumeLayout(false);
            this.tbpCounter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tbpControl;
        private System.Windows.Forms.TabPage tbpCounter;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCountMinus;
        private System.Windows.Forms.Button btnCountPlus;
        private System.Windows.Forms.TabPage tbpRandom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.NumericUpDown nudTo;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.Label lblRandomResult;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button btnRandomListClear;
        private System.Windows.Forms.Button btnRandomListCopy;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.TabPage tbpNote;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertTime;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.TabPage tbpPass;
        private System.Windows.Forms.CheckedListBox clbPassProp;
        private System.Windows.Forms.Label lblPassLength;
        private System.Windows.Forms.NumericUpDown nudPassLength;
        private System.Windows.Forms.Button btnPassGreate;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TabPage tbpConv;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ComboBox cbMetrica;
    }
}


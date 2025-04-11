namespace WinFormsPL
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.typeSearchButton = new System.Windows.Forms.Button();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.developerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.softwaresDataGrid = new System.Windows.Forms.DataGridView();
            this.addSoftwarePage = new System.Windows.Forms.TabPage();
            this.addTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addSoftwareButton = new System.Windows.Forms.Button();
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPriceLabel = new System.Windows.Forms.Label();
            this.addExpiredDateLabel = new System.Windows.Forms.Label();
            this.addDeveloperTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.addDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresDataGrid)).BeginInit();
            this.addSoftwarePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(782, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.addSoftwarePage);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 552);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.resetButton);
            this.mainPage.Controls.Add(this.searchNameButton);
            this.mainPage.Controls.Add(this.searchNameTextBox);
            this.mainPage.Controls.Add(this.label9);
            this.mainPage.Controls.Add(this.typeSearchButton);
            this.mainPage.Controls.Add(this.availableCheckBox);
            this.mainPage.Controls.Add(this.label8);
            this.mainPage.Controls.Add(this.searchTypeComboBox);
            this.mainPage.Controls.Add(this.deleteButton);
            this.mainPage.Controls.Add(this.label7);
            this.mainPage.Controls.Add(this.priceTextBox);
            this.mainPage.Controls.Add(this.priceLabel);
            this.mainPage.Controls.Add(this.statusTextBox);
            this.mainPage.Controls.Add(this.label5);
            this.mainPage.Controls.Add(this.developerTextBox);
            this.mainPage.Controls.Add(this.label4);
            this.mainPage.Controls.Add(this.nameTextBox);
            this.mainPage.Controls.Add(this.label3);
            this.mainPage.Controls.Add(this.typeTextBox);
            this.mainPage.Controls.Add(this.label2);
            this.mainPage.Controls.Add(this.label1);
            this.mainPage.Controls.Add(this.softwaresDataGrid);
            this.mainPage.Location = new System.Drawing.Point(4, 25);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(774, 523);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Список ПО";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(602, 407);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(135, 65);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Сбросить фильтры";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchNameButton
            // 
            this.searchNameButton.Location = new System.Drawing.Point(439, 468);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(130, 35);
            this.searchNameButton.TabIndex = 20;
            this.searchNameButton.Text = "Найти";
            this.searchNameButton.UseVisualStyleBackColor = true;
            this.searchNameButton.Click += new System.EventHandler(this.searchNameButton_Click);
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(219, 474);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(214, 22);
            this.searchNameTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Поиск по названию:";
            // 
            // typeSearchButton
            // 
            this.typeSearchButton.Location = new System.Drawing.Point(439, 399);
            this.typeSearchButton.Name = "typeSearchButton";
            this.typeSearchButton.Size = new System.Drawing.Size(130, 51);
            this.typeSearchButton.TabIndex = 17;
            this.typeSearchButton.Text = "Найти";
            this.typeSearchButton.UseVisualStyleBackColor = true;
            this.typeSearchButton.Click += new System.EventHandler(this.typeSearchButton_Click);
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.AutoSize = true;
            this.availableCheckBox.Location = new System.Drawing.Point(219, 430);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(214, 20);
            this.availableCheckBox.TabIndex = 16;
            this.availableCheckBox.Text = "Показать только доступные";
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Поиск по типу ПО:";
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Location = new System.Drawing.Point(219, 402);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(214, 24);
            this.searchTypeComboBox.TabIndex = 14;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(30, 337);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(225, 28);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Детальная информация";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(30, 295);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(225, 22);
            this.priceTextBox.TabIndex = 11;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(27, 276);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 16);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Цена:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(30, 241);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(225, 22);
            this.statusTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Статус:";
            // 
            // developerTextBox
            // 
            this.developerTextBox.Location = new System.Drawing.Point(30, 191);
            this.developerTextBox.Name = "developerTextBox";
            this.developerTextBox.ReadOnly = true;
            this.developerTextBox.Size = new System.Drawing.Size(225, 22);
            this.developerTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Разработчик:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(30, 139);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(225, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(30, 90);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(225, 22);
            this.typeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Программное обеспечение";
            // 
            // softwaresDataGrid
            // 
            this.softwaresDataGrid.AllowUserToAddRows = false;
            this.softwaresDataGrid.AllowUserToDeleteRows = false;
            this.softwaresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwaresDataGrid.Location = new System.Drawing.Point(304, 71);
            this.softwaresDataGrid.Name = "softwaresDataGrid";
            this.softwaresDataGrid.ReadOnly = true;
            this.softwaresDataGrid.RowHeadersWidth = 51;
            this.softwaresDataGrid.RowTemplate.Height = 24;
            this.softwaresDataGrid.Size = new System.Drawing.Size(433, 294);
            this.softwaresDataGrid.TabIndex = 0;
            this.softwaresDataGrid.CurrentCellChanged += new System.EventHandler(this.softwaresDataGrid_CurrentCellChanged);
            // 
            // addSoftwarePage
            // 
            this.addSoftwarePage.Controls.Add(this.addDateTimePicker);
            this.addSoftwarePage.Controls.Add(this.addTypeComboBox);
            this.addSoftwarePage.Controls.Add(this.addSoftwareButton);
            this.addSoftwarePage.Controls.Add(this.addPriceTextBox);
            this.addSoftwarePage.Controls.Add(this.addPriceLabel);
            this.addSoftwarePage.Controls.Add(this.addExpiredDateLabel);
            this.addSoftwarePage.Controls.Add(this.addDeveloperTextBox);
            this.addSoftwarePage.Controls.Add(this.label12);
            this.addSoftwarePage.Controls.Add(this.addNameTextBox);
            this.addSoftwarePage.Controls.Add(this.label13);
            this.addSoftwarePage.Controls.Add(this.label14);
            this.addSoftwarePage.Location = new System.Drawing.Point(4, 25);
            this.addSoftwarePage.Name = "addSoftwarePage";
            this.addSoftwarePage.Padding = new System.Windows.Forms.Padding(3);
            this.addSoftwarePage.Size = new System.Drawing.Size(774, 523);
            this.addSoftwarePage.TabIndex = 1;
            this.addSoftwarePage.Text = "Добавить ПО";
            this.addSoftwarePage.UseVisualStyleBackColor = true;
            // 
            // addTypeComboBox
            // 
            this.addTypeComboBox.FormattingEnabled = true;
            this.addTypeComboBox.Location = new System.Drawing.Point(268, 114);
            this.addTypeComboBox.Name = "addTypeComboBox";
            this.addTypeComboBox.Size = new System.Drawing.Size(256, 24);
            this.addTypeComboBox.TabIndex = 25;
            this.addTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.addTypeComboBox_SelectedIndexChanged);
            // 
            // addSoftwareButton
            // 
            this.addSoftwareButton.Location = new System.Drawing.Point(268, 366);
            this.addSoftwareButton.Name = "addSoftwareButton";
            this.addSoftwareButton.Size = new System.Drawing.Size(256, 38);
            this.addSoftwareButton.TabIndex = 24;
            this.addSoftwareButton.Text = "Добавить";
            this.addSoftwareButton.UseVisualStyleBackColor = true;
            this.addSoftwareButton.Click += new System.EventHandler(this.addSoftwareButton_Click);
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(268, 318);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(256, 22);
            this.addPriceTextBox.TabIndex = 23;
            // 
            // addPriceLabel
            // 
            this.addPriceLabel.AutoSize = true;
            this.addPriceLabel.Location = new System.Drawing.Point(265, 299);
            this.addPriceLabel.Name = "addPriceLabel";
            this.addPriceLabel.Size = new System.Drawing.Size(43, 16);
            this.addPriceLabel.TabIndex = 22;
            this.addPriceLabel.Text = "Цена:";
            // 
            // addExpiredDateLabel
            // 
            this.addExpiredDateLabel.AutoSize = true;
            this.addExpiredDateLabel.Location = new System.Drawing.Point(265, 245);
            this.addExpiredDateLabel.Name = "addExpiredDateLabel";
            this.addExpiredDateLabel.Size = new System.Drawing.Size(259, 16);
            this.addExpiredDateLabel.TabIndex = 20;
            this.addExpiredDateLabel.Text = "Дата истечения срока использования:";
            // 
            // addDeveloperTextBox
            // 
            this.addDeveloperTextBox.Location = new System.Drawing.Point(268, 214);
            this.addDeveloperTextBox.Name = "addDeveloperTextBox";
            this.addDeveloperTextBox.Size = new System.Drawing.Size(256, 22);
            this.addDeveloperTextBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Разработчик:";
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(268, 162);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(256, 22);
            this.addNameTextBox.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Название:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(265, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Тип:";
            // 
            // addDateTimePicker
            // 
            this.addDateTimePicker.Location = new System.Drawing.Point(268, 274);
            this.addDateTimePicker.Name = "addDateTimePicker";
            this.addDateTimePicker.Size = new System.Drawing.Size(256, 22);
            this.addDateTimePicker.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresDataGrid)).EndInit();
            this.addSoftwarePage.ResumeLayout(false);
            this.addSoftwarePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.DataGridView softwaresDataGrid;
        private System.Windows.Forms.TabPage addSoftwarePage;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox developerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button typeSearchButton;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox addTypeComboBox;
        private System.Windows.Forms.Button addSoftwareButton;
        private System.Windows.Forms.TextBox addPriceTextBox;
        private System.Windows.Forms.Label addPriceLabel;
        private System.Windows.Forms.Label addExpiredDateLabel;
        private System.Windows.Forms.TextBox addDeveloperTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker addDateTimePicker;
    }
}
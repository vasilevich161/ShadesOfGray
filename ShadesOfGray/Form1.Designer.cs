namespace ShadesOfGray
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.grayButton = new System.Windows.Forms.Button();
            this.radioButton128x64 = new System.Windows.Forms.RadioButton();
            this.radioButton240x64 = new System.Windows.Forms.RadioButton();
            this.radioButton128x32 = new System.Windows.Forms.RadioButton();
            this.radioButton240x128 = new System.Windows.Forms.RadioButton();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.labelTest = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth1 = new System.Windows.Forms.Label();
            this.labelHeight1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openButton.Location = new System.Drawing.Point(29, 22);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 28);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveButton.Location = new System.Drawing.Point(415, 22);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(143, 28);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить рисунок";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // grayButton
            // 
            this.grayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grayButton.Location = new System.Drawing.Point(223, 22);
            this.grayButton.Margin = new System.Windows.Forms.Padding(4);
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(114, 28);
            this.grayButton.TabIndex = 4;
            this.grayButton.Text = "Ч/Б";
            this.grayButton.UseVisualStyleBackColor = true;
            this.grayButton.Click += new System.EventHandler(this.grayButton_Click);
            // 
            // radioButton128x64
            // 
            this.radioButton128x64.AutoSize = true;
            this.radioButton128x64.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton128x64.Location = new System.Drawing.Point(29, 74);
            this.radioButton128x64.Name = "radioButton128x64";
            this.radioButton128x64.Size = new System.Drawing.Size(78, 22);
            this.radioButton128x64.TabIndex = 5;
            this.radioButton128x64.Text = "128x64";
            this.radioButton128x64.UseVisualStyleBackColor = true;
            this.radioButton128x64.CheckedChanged += new System.EventHandler(this.radioButton128x64_CheckedChanged);
            // 
            // radioButton240x64
            // 
            this.radioButton240x64.AutoSize = true;
            this.radioButton240x64.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton240x64.Location = new System.Drawing.Point(29, 101);
            this.radioButton240x64.Name = "radioButton240x64";
            this.radioButton240x64.Size = new System.Drawing.Size(78, 22);
            this.radioButton240x64.TabIndex = 6;
            this.radioButton240x64.Text = "240x64";
            this.radioButton240x64.UseVisualStyleBackColor = true;
            this.radioButton240x64.CheckedChanged += new System.EventHandler(this.radioButton240x64_CheckedChanged);
            // 
            // radioButton128x32
            // 
            this.radioButton128x32.AutoSize = true;
            this.radioButton128x32.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton128x32.Location = new System.Drawing.Point(29, 128);
            this.radioButton128x32.Name = "radioButton128x32";
            this.radioButton128x32.Size = new System.Drawing.Size(78, 22);
            this.radioButton128x32.TabIndex = 7;
            this.radioButton128x32.Text = "128x32";
            this.radioButton128x32.UseVisualStyleBackColor = true;
            this.radioButton128x32.CheckedChanged += new System.EventHandler(this.radioButton128x32_CheckedChanged);
            // 
            // radioButton240x128
            // 
            this.radioButton240x128.AutoSize = true;
            this.radioButton240x128.Checked = true;
            this.radioButton240x128.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton240x128.Location = new System.Drawing.Point(163, 74);
            this.radioButton240x128.Name = "radioButton240x128";
            this.radioButton240x128.Size = new System.Drawing.Size(86, 22);
            this.radioButton240x128.TabIndex = 8;
            this.radioButton240x128.TabStop = true;
            this.radioButton240x128.Text = "240x128";
            this.radioButton240x128.UseVisualStyleBackColor = true;
            this.radioButton240x128.CheckedChanged += new System.EventHandler(this.radioButton240x128_CheckedChanged);
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonRandom.Location = new System.Drawing.Point(163, 101);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(78, 22);
            this.radioButtonRandom.TabIndex = 10;
            this.radioButtonRandom.Text = "значек";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.radioButtonRandom_CheckedChanged);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelTest.Location = new System.Drawing.Point(282, 78);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(31, 17);
            this.labelTest.TabIndex = 11;
            this.labelTest.Text = "test";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelWidth.Location = new System.Drawing.Point(160, 125);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(59, 17);
            this.labelWidth.TabIndex = 12;
            this.labelWidth.Text = "ширина";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelHeight.Location = new System.Drawing.Point(160, 142);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(55, 17);
            this.labelHeight.TabIndex = 13;
            this.labelHeight.Text = "высота";
            // 
            // labelWidth1
            // 
            this.labelWidth1.AutoSize = true;
            this.labelWidth1.Location = new System.Drawing.Point(237, 125);
            this.labelWidth1.Name = "labelWidth1";
            this.labelWidth1.Size = new System.Drawing.Size(16, 17);
            this.labelWidth1.TabIndex = 14;
            this.labelWidth1.Text = "  ";
            // 
            // labelHeight1
            // 
            this.labelHeight1.AutoSize = true;
            this.labelHeight1.Location = new System.Drawing.Point(237, 142);
            this.labelHeight1.Name = "labelHeight1";
            this.labelHeight1.Size = new System.Drawing.Size(16, 17);
            this.labelHeight1.TabIndex = 15;
            this.labelHeight1.Text = "  ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(29, 306);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 149);
            this.textBox1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(318, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 128);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ShadesOfGray.Properties.Resources._0_96_OLED_;
            this.pictureBox1.Location = new System.Drawing.Point(29, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 128);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 492);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelHeight1);
            this.Controls.Add(this.labelWidth1);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.radioButtonRandom);
            this.Controls.Add(this.radioButton240x128);
            this.Controls.Add(this.radioButton128x32);
            this.Controls.Add(this.radioButton240x64);
            this.Controls.Add(this.radioButton128x64);
            this.Controls.Add(this.grayButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 530);
            this.Name = "Form1";
            this.Text = "Конвектор для OLED";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button grayButton;
        private System.Windows.Forms.RadioButton radioButton128x64;
        private System.Windows.Forms.RadioButton radioButton240x64;
        private System.Windows.Forms.RadioButton radioButton128x32;
        private System.Windows.Forms.RadioButton radioButton240x128;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth1;
        private System.Windows.Forms.Label labelHeight1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


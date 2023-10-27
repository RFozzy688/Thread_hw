namespace Thread_hw
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RestartPrime = new System.Windows.Forms.Button();
            this.ResumePrime = new System.Windows.Forms.Button();
            this.SuspendPrime = new System.Windows.Forms.Button();
            this.numericPrimeMax = new System.Windows.Forms.NumericUpDown();
            this.numericPrimeMin = new System.Windows.Forms.NumericUpDown();
            this.PrimeNumberTextBox = new System.Windows.Forms.TextBox();
            this.StopPrime = new System.Windows.Forms.Button();
            this.StartPrime = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.FibonacciTextBox = new System.Windows.Forms.TextBox();
            this.StopFibonacci = new System.Windows.Forms.Button();
            this.StartFibonacci = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RestartPrime);
            this.groupBox1.Controls.Add(this.ResumePrime);
            this.groupBox1.Controls.Add(this.SuspendPrime);
            this.groupBox1.Controls.Add(this.numericPrimeMax);
            this.groupBox1.Controls.Add(this.numericPrimeMin);
            this.groupBox1.Controls.Add(this.PrimeNumberTextBox);
            this.groupBox1.Controls.Add(this.StopPrime);
            this.groupBox1.Controls.Add(this.StartPrime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Простые числа";
            // 
            // RestartPrime
            // 
            this.RestartPrime.Location = new System.Drawing.Point(66, 349);
            this.RestartPrime.Name = "RestartPrime";
            this.RestartPrime.Size = new System.Drawing.Size(75, 23);
            this.RestartPrime.TabIndex = 6;
            this.RestartPrime.Text = "Restart";
            this.RestartPrime.UseVisualStyleBackColor = true;
            this.RestartPrime.Click += new System.EventHandler(this.RestartPrime_Click);
            // 
            // ResumePrime
            // 
            this.ResumePrime.Location = new System.Drawing.Point(119, 310);
            this.ResumePrime.Name = "ResumePrime";
            this.ResumePrime.Size = new System.Drawing.Size(75, 23);
            this.ResumePrime.TabIndex = 5;
            this.ResumePrime.Text = "Resume";
            this.ResumePrime.UseVisualStyleBackColor = true;
            this.ResumePrime.Click += new System.EventHandler(this.ResumePrime_Click);
            // 
            // SuspendPrime
            // 
            this.SuspendPrime.Location = new System.Drawing.Point(18, 310);
            this.SuspendPrime.Name = "SuspendPrime";
            this.SuspendPrime.Size = new System.Drawing.Size(75, 23);
            this.SuspendPrime.TabIndex = 4;
            this.SuspendPrime.Text = "Suspend";
            this.SuspendPrime.UseVisualStyleBackColor = true;
            this.SuspendPrime.Click += new System.EventHandler(this.SuspendPrime_Click);
            // 
            // numericPrimeMax
            // 
            this.numericPrimeMax.Location = new System.Drawing.Point(119, 224);
            this.numericPrimeMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPrimeMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericPrimeMax.Name = "numericPrimeMax";
            this.numericPrimeMax.Size = new System.Drawing.Size(75, 20);
            this.numericPrimeMax.TabIndex = 3;
            this.numericPrimeMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericPrimeMin
            // 
            this.numericPrimeMin.Location = new System.Drawing.Point(18, 224);
            this.numericPrimeMin.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericPrimeMin.Name = "numericPrimeMin";
            this.numericPrimeMin.Size = new System.Drawing.Size(75, 20);
            this.numericPrimeMin.TabIndex = 1;
            this.numericPrimeMin.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // PrimeNumberTextBox
            // 
            this.PrimeNumberTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PrimeNumberTextBox.Location = new System.Drawing.Point(18, 19);
            this.PrimeNumberTextBox.Multiline = true;
            this.PrimeNumberTextBox.Name = "PrimeNumberTextBox";
            this.PrimeNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrimeNumberTextBox.Size = new System.Drawing.Size(176, 187);
            this.PrimeNumberTextBox.TabIndex = 1;
            // 
            // StopPrime
            // 
            this.StopPrime.Location = new System.Drawing.Point(119, 263);
            this.StopPrime.Name = "StopPrime";
            this.StopPrime.Size = new System.Drawing.Size(75, 23);
            this.StopPrime.TabIndex = 2;
            this.StopPrime.Text = "Stop";
            this.StopPrime.UseVisualStyleBackColor = true;
            this.StopPrime.Click += new System.EventHandler(this.StopPrime_Click);
            // 
            // StartPrime
            // 
            this.StartPrime.Location = new System.Drawing.Point(18, 263);
            this.StartPrime.Name = "StartPrime";
            this.StartPrime.Size = new System.Drawing.Size(75, 23);
            this.StartPrime.TabIndex = 1;
            this.StartPrime.Text = "Start";
            this.StartPrime.UseVisualStyleBackColor = true;
            this.StartPrime.Click += new System.EventHandler(this.StartPrime_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.FibonacciTextBox);
            this.groupBox2.Controls.Add(this.StopFibonacci);
            this.groupBox2.Controls.Add(this.StartFibonacci);
            this.groupBox2.Location = new System.Drawing.Point(258, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Числа Фибоначчи";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(65, 349);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Restart";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Resume";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Suspend";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FibonacciTextBox
            // 
            this.FibonacciTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FibonacciTextBox.Location = new System.Drawing.Point(18, 19);
            this.FibonacciTextBox.Multiline = true;
            this.FibonacciTextBox.Name = "FibonacciTextBox";
            this.FibonacciTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FibonacciTextBox.Size = new System.Drawing.Size(176, 187);
            this.FibonacciTextBox.TabIndex = 1;
            // 
            // StopFibonacci
            // 
            this.StopFibonacci.Location = new System.Drawing.Point(119, 263);
            this.StopFibonacci.Name = "StopFibonacci";
            this.StopFibonacci.Size = new System.Drawing.Size(75, 23);
            this.StopFibonacci.TabIndex = 2;
            this.StopFibonacci.Text = "Stop";
            this.StopFibonacci.UseVisualStyleBackColor = true;
            this.StopFibonacci.Click += new System.EventHandler(this.StopFibonacci_Click);
            // 
            // StartFibonacci
            // 
            this.StartFibonacci.Location = new System.Drawing.Point(18, 263);
            this.StartFibonacci.Name = "StartFibonacci";
            this.StartFibonacci.Size = new System.Drawing.Size(75, 23);
            this.StartFibonacci.TabIndex = 1;
            this.StartFibonacci.Text = "Start";
            this.StartFibonacci.UseVisualStyleBackColor = true;
            this.StartFibonacci.Click += new System.EventHandler(this.StartFibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StopPrime;
        private System.Windows.Forms.Button StartPrime;
        private System.Windows.Forms.NumericUpDown numericPrimeMin;
        private System.Windows.Forms.TextBox PrimeNumberTextBox;
        private System.Windows.Forms.NumericUpDown numericPrimeMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FibonacciTextBox;
        private System.Windows.Forms.Button StopFibonacci;
        private System.Windows.Forms.Button StartFibonacci;
        private System.Windows.Forms.Button RestartPrime;
        private System.Windows.Forms.Button ResumePrime;
        private System.Windows.Forms.Button SuspendPrime;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


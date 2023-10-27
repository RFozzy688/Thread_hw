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
            this.StartPrime = new System.Windows.Forms.Button();
            this.StopPrime = new System.Windows.Forms.Button();
            this.PrimeNumberTextBox = new System.Windows.Forms.TextBox();
            this.numericPrimeMin = new System.Windows.Forms.NumericUpDown();
            this.numericPrimeMax = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeMax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            // PrimeNumberTextBox
            // 
            this.PrimeNumberTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PrimeNumberTextBox.Location = new System.Drawing.Point(18, 19);
            this.PrimeNumberTextBox.Multiline = true;
            this.PrimeNumberTextBox.Name = "PrimeNumberTextBox";
            this.PrimeNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrimeNumberTextBox.Size = new System.Drawing.Size(176, 81);
            this.PrimeNumberTextBox.TabIndex = 1;
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
            // numericPrimeMax
            // 
            this.numericPrimeMax.Location = new System.Drawing.Point(119, 224);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StopPrime;
        private System.Windows.Forms.Button StartPrime;
        private System.Windows.Forms.NumericUpDown numericPrimeMin;
        private System.Windows.Forms.TextBox PrimeNumberTextBox;
        private System.Windows.Forms.NumericUpDown numericPrimeMax;
    }
}


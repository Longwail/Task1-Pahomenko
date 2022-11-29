namespace Task1Forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CnumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите А:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введиет В:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите C:";
            // 
            // AnumericUpDown
            // 
            this.AnumericUpDown.DecimalPlaces = 2;
            this.AnumericUpDown.Location = new System.Drawing.Point(108, 18);
            this.AnumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.AnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AnumericUpDown.Name = "AnumericUpDown";
            this.AnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.AnumericUpDown.TabIndex = 7;
            this.AnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BnumericUpDown
            // 
            this.BnumericUpDown.DecimalPlaces = 2;
            this.BnumericUpDown.Location = new System.Drawing.Point(108, 46);
            this.BnumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.BnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BnumericUpDown.Name = "BnumericUpDown";
            this.BnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.BnumericUpDown.TabIndex = 8;
            this.BnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CnumericUpDown
            // 
            this.CnumericUpDown.DecimalPlaces = 2;
            this.CnumericUpDown.Location = new System.Drawing.Point(108, 74);
            this.CnumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.CnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CnumericUpDown.Name = "CnumericUpDown";
            this.CnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CnumericUpDown.TabIndex = 9;
            this.CnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 276);
            this.Controls.Add(this.CnumericUpDown);
            this.Controls.Add(this.BnumericUpDown);
            this.Controls.Add(this.AnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AnumericUpDown;
        private System.Windows.Forms.NumericUpDown BnumericUpDown;
        private System.Windows.Forms.NumericUpDown CnumericUpDown;
    }
}


namespace CalculatorWindowsForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbOp = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "op";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(55, 21);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 3;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(55, 48);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 4;
            // 
            // tbOp
            // 
            this.tbOp.Location = new System.Drawing.Point(55, 74);
            this.tbOp.Name = "tbOp";
            this.tbOp.Size = new System.Drawing.Size(100, 20);
            this.tbOp.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 100);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(139, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // tbRes
            // 
            this.tbRes.Location = new System.Drawing.Point(55, 134);
            this.tbRes.Name = "tbRes";
            this.tbRes.ReadOnly = true;
            this.tbRes.Size = new System.Drawing.Size(100, 20);
            this.tbRes.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbOp);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbOp;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRes;
    }
}


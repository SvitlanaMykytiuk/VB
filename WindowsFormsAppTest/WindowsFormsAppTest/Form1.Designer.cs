namespace WindowsFormsAppTest
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btnEqual = new System.Windows.Forms.Button();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(149, 317);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(90, 46);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(303, 316);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(90, 47);
			this.btn2.TabIndex = 1;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btnEqual
			// 
			this.btnEqual.Location = new System.Drawing.Point(552, 392);
			this.btnEqual.Name = "btnEqual";
			this.btnEqual.Size = new System.Drawing.Size(90, 46);
			this.btnEqual.TabIndex = 2;
			this.btnEqual.Text = "=";
			this.btnEqual.UseVisualStyleBackColor = true;
			this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
			// 
			// btnMinus
			// 
			this.btnMinus.Location = new System.Drawing.Point(552, 315);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(90, 47);
			this.btnMinus.TabIndex = 3;
			this.btnMinus.Text = "-";
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Location = new System.Drawing.Point(552, 240);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(90, 46);
			this.btnPlus.TabIndex = 4;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// txtDisplay
			// 
			this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisplay.Location = new System.Drawing.Point(478, 21);
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.ReadOnly = true;
			this.txtDisplay.Size = new System.Drawing.Size(300, 48);
			this.txtDisplay.TabIndex = 5;
			this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(432, 316);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(90, 46);
			this.btn3.TabIndex = 6;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn4
			// 
			this.btn4.Location = new System.Drawing.Point(149, 239);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(90, 47);
			this.btn4.TabIndex = 7;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// btn5
			// 
			this.btn5.Location = new System.Drawing.Point(303, 239);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(90, 47);
			this.btn5.TabIndex = 8;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			// 
			// btn6
			// 
			this.btn6.Location = new System.Drawing.Point(432, 239);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(90, 47);
			this.btn6.TabIndex = 9;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(149, 99);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(90, 45);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "C";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btn7
			// 
			this.btn7.Location = new System.Drawing.Point(149, 163);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(90, 46);
			this.btn7.TabIndex = 11;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.btn7_Click);
			// 
			// btn8
			// 
			this.btn8.Location = new System.Drawing.Point(303, 163);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(90, 46);
			this.btn8.TabIndex = 12;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.btn8_Click);
			// 
			// btn9
			// 
			this.btn9.Location = new System.Drawing.Point(432, 163);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(90, 46);
			this.btn9.TabIndex = 13;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.btn9_Click);
			// 
			// btn0
			// 
			this.btn0.Location = new System.Drawing.Point(303, 393);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(90, 45);
			this.btn0.TabIndex = 14;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btn0_Click);
			// 
			// btnDivide
			// 
			this.btnDivide.Location = new System.Drawing.Point(552, 163);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(90, 46);
			this.btnDivide.TabIndex = 15;
			this.btnDivide.Text = "/";
			this.btnDivide.UseVisualStyleBackColor = true;
			this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
			// 
			// btnMultiply
			// 
			this.btnMultiply.Location = new System.Drawing.Point(552, 99);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.Size = new System.Drawing.Size(90, 45);
			this.btnMultiply.TabIndex = 16;
			this.btnMultiply.Text = "*";
			this.btnMultiply.UseVisualStyleBackColor = true;
			this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnMultiply);
			this.Controls.Add(this.btnDivide);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.txtDisplay);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.btnMinus);
			this.Controls.Add(this.btnEqual);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btnEqual;
		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.TextBox txtDisplay;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Button btnMultiply;
	}
}


namespace GuessNumberC
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
			this.textBoxGuess = new System.Windows.Forms.TextBox();
			this.buttonGuess = new System.Windows.Forms.Button();
			this.labelResult = new System.Windows.Forms.Label();
			this.buttonNewGame = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxGuess
			// 
			this.textBoxGuess.Location = new System.Drawing.Point(277, 156);
			this.textBoxGuess.Name = "textBoxGuess";
			this.textBoxGuess.Size = new System.Drawing.Size(206, 26);
			this.textBoxGuess.TabIndex = 0;
			// 
			// buttonGuess
			// 
			this.buttonGuess.Location = new System.Drawing.Point(317, 228);
			this.buttonGuess.Name = "buttonGuess";
			this.buttonGuess.Size = new System.Drawing.Size(102, 44);
			this.buttonGuess.TabIndex = 1;
			this.buttonGuess.Text = "Guess";
			this.buttonGuess.UseVisualStyleBackColor = true;
			this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(349, 336);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(0, 30);
			this.labelResult.TabIndex = 2;
			// 
			// buttonNewGame
			// 
			this.buttonNewGame.Location = new System.Drawing.Point(291, 397);
			this.buttonNewGame.Name = "buttonNewGame";
			this.buttonNewGame.Size = new System.Drawing.Size(142, 41);
			this.buttonNewGame.TabIndex = 3;
			this.buttonNewGame.Text = "Neue Runde";
			this.buttonNewGame.UseVisualStyleBackColor = true;
			this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonNewGame);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.buttonGuess);
			this.Controls.Add(this.textBoxGuess);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxGuess;
		private System.Windows.Forms.Button buttonGuess;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Button buttonNewGame;
	}
}


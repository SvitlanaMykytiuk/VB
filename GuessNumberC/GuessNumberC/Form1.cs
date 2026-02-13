using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberC
{
	public partial class Form1 : Form
	{
		private int secretNumber;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Random rnd = new Random();
			secretNumber = rnd.Next(1, 101);
		}

		private void buttonGuess_Click(object sender, EventArgs e)
		{
			if (int.TryParse(textBoxGuess.Text, out int guess))
			{
				if (guess < secretNumber)
					labelResult.Text = "Zu niedrig!"; // замало
				else if (guess > secretNumber)
					labelResult.Text = "Zu hoch!"; // забагато
				else
					labelResult.Text = "Richtig! Du hast es erraten!"; // вгадано
			}
			else
			{
				labelResult.Text = "Gib eine gültige Zahl ein!"; // введи правильне число
			}
		}

		private void buttonNewGame_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			secretNumber = rnd.Next(1, 101); // нове число від 1 до 100

			textBoxGuess.Text = ""; // очистити поле вводу
			labelResult.Text = "";  // очистити повідомлення
		}
	}
}

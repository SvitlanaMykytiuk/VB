using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
	public partial class Form1 : Form
	{
		double firstNumber = 0;
		string operation = "";
		public Form1()
		{
			InitializeComponent();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "2";
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			firstNumber = Convert.ToDouble(txtDisplay.Text);
			operation = "+";
			txtDisplay.Clear();
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			firstNumber = Convert.ToDouble(txtDisplay.Text);
			operation = "-";
			txtDisplay.Clear();
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
			double secondNumber = Convert.ToDouble(txtDisplay.Text);
			double result = 0;

			switch (operation)
			{
				case "+":
					result = firstNumber + secondNumber;
					break;
				case "-":
					result = firstNumber - secondNumber;
					break;
				case "*":
					result = firstNumber * secondNumber;
					break;
				case "/":
					result = firstNumber / secondNumber;
					break;
			}

			txtDisplay.Text = result.ToString();
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "3";
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "4";
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "5";
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "6";
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "7";
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "8";
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "9";
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += "0";
		}

		private void btnDivide_Click(object sender, EventArgs e)
		{
			firstNumber = Convert.ToDouble(txtDisplay.Text);
			operation = "/";
			txtDisplay.Clear();
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			firstNumber = Convert.ToDouble(txtDisplay.Text);
			operation = "*";
			txtDisplay.Clear();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDisplay.Clear();
			firstNumber = 0;
			operation = "";
		}
	}
}

using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace ExpenseApp;

public partial class MainPage : ContentPage
{
	// Колекція витрат для CollectionView
	private ObservableCollection<Expense> expenses = new ObservableCollection<Expense>();

	public MainPage()
	{
		InitializeComponent();

		// Прив'язуємо список до CollectionView
		cvExpenses.ItemsSource = expenses;

		// Встановлюємо перший елемент у Picker
		pickerCategory.SelectedIndex = 0;
	}

	// Клас витрати
	public class Expense
	{
		public DateTime Date { get; set; }
		public string Category { get; set; }
		public decimal Amount { get; set; }
	}

	// Натискання кнопки "Add Expense"
	private void OnAddExpenseClicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(entryAmount.Text) || !decimal.TryParse(entryAmount.Text, out decimal amount))
		{
			DisplayAlert("Error", "Enter valid amount", "OK");
			return;
		}

		// Додаємо витрату у колекцію
		expenses.Add(new Expense
		{
			Date = dpDate.Date,
			Category = pickerCategory.SelectedItem.ToString(),
			Amount = amount
		});

		// Оновлюємо total
		CalculateTotal();

		// Очищаємо поле суми
		entryAmount.Text = string.Empty;
	}

	// Підрахунок загальної суми
	private void CalculateTotal()
	{
		decimal total = 0;
		foreach (var exp in expenses)
		{
			total += exp.Amount;
		}
		lblTotal.Text = $"Total: {total:0.00}";
	}
}


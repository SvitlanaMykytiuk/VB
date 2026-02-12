using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace mauiApp1;

public partial class MainPage : ContentPage
{
	private readonly HttpClient _httpClient = new();

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnRestartServiceClicked(object sender, EventArgs e)
	{
		try
		{
			var data = new { serviceName = "MyService" };
			var json = JsonSerializer.Serialize(data);
			var content = new StringContent(json, Encoding.UTF8, "application/json");

			var response = await _httpClient.PostAsync(
				"https://YOUR_API_URL/api/service/restart",
				content);

			if (response.IsSuccessStatusCode)
				await DisplayAlert("Ok", "Service restarted", "Close");
			else
				await DisplayAlert("Error", "Restart Failed", "Close");
		}
		catch (Exception ex)
		{
			await DisplayAlert("Exception", ex.Message, "Close");
		}
	}
}
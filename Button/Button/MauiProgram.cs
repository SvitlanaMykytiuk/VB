public MainPage()
{
	var button = new Button
	{
		Text = "Klick mich!"
	};

	button.Clicked += async (s, e) =>
	{
		await DisplayAlert("Info", "Hello World", "OK");
	};

	Content = new VerticalStackLayout
	{
		Children = { button },
		VerticalOptions = LayoutOptions.Center,
		HorizontalOptions = LayoutOptions.Center
	};
}
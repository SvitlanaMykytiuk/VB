using MauiApp1;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace mauiApp1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>();

		return builder.Build();
	}
}
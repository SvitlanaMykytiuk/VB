using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using newTest;

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

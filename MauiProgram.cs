using AppMarkupValidator.ViewModels;
using CommunityToolkit.Maui.Markup;

namespace AppMarkupValidator;

// muy bueno par explicar validacióens
// https://www.youtube.com/watch?v=YbxeNvn5Xm8&t=1s

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Initialise the toolkit
        builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();

        builder.Services.AddSingleton<miViewModel>();
        builder.Services.AddTransient<MainPage>();

        builder.Services.AddTransient<ContadorPage>();
        builder.Services.AddTransient<MainPageCSharpMarkupDI>();


        builder.Services.AddSingleton<vmPersona>();
        builder.Services.AddTransient<MainPageCSharpMarkupValidationfluentDI>();
        builder.Services.AddTransient<MainPageCSharpValidationfluentDI>();


        return builder.Build();
    }
}

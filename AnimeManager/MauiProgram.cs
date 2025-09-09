using Microsoft.Extensions.Logging;
using AnimeManager.Services;
using Microsoft.Extensions.DependencyInjection;


namespace AnimeManager
{
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
                });
            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<UsuarioService>();
            builder.Services.AddSingleton<AnimeService>();
            builder.Services.AddHttpClient<TodoService>(); 
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

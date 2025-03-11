using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TestOverIT.BackEnds;
using TestOverIT.SearchPhoto.ViewModel;

namespace TestOverIT
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<FlickrProxy>();
            builder.Services.AddTransient<SearchPhotoViewModel>();

            return builder.Build();
        }
    }
}

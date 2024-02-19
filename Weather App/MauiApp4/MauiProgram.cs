using MauiApp4.MVVM.Models;
using MauiApp4.MVVM.Repository;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace MauiApp4
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("TRANA___.TTF", "myFont"); 
                    fonts.AddFont("fontello.ttf", "iconFont");
                    fonts.AddFont("Bison.ttf", "gradientFont");
                    fonts.AddFont("information.ttf", "iconFont2");

                    fonts.AddFont("opensans-italic-webfont.ttf", "Lucida");
                    fonts.AddFont("opensans-bold-webfont.ttf", "LucidaBold");



                });

            //builder.Services.AddSingleton<CustomerRepository>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
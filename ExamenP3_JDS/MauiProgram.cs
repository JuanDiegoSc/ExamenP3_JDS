using Microsoft.Extensions.Logging;
using ExamenP3_JDS.Servicios;

namespace ExamenP3_JDS
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

            builder.Services.AddSingleton<IPersonajesJDS, PersonajeServiceJDS>();
            builder.Services.AddTransient<MainPage>();


            //Base de datos
            string dbPath = FileAccessHelperJDS.GetLocalFilePath("PersonajeDB_JDS");
            //builder.Services.AddSingleton<PersonajeRepositoryJDS>(s => ActivatorUtilities.CreateInstance<PersonajeRepositoryJDS>(s, dbPath));
            return builder.Build();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

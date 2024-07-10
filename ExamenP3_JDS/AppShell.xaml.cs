namespace ExamenP3_JDS
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.MostrarDatosSQLite), typeof(Views.MostrarDatosSQLite));
        }
    }
}

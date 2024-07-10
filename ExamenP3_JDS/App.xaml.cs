namespace ExamenP3_JDS
{
    public partial class App : Application
    {
        //public static PersonajeRepositoryJDS personajesRepo { get; private set; }
        public App(/*PersonajeRepositoryJDS repo*/)
        {
            InitializeComponent();

            MainPage = new AppShell();

            //personajesRepo = repo;
        }
    }
}

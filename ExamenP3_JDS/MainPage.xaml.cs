using ExamenP3_JDS.Servicios;

namespace ExamenP3_JDS
{
    public partial class MainPage : ContentPage
    {
        private readonly IPersonajesJDS _personajesJDS;

        public MainPage(IPersonajesJDS personajesJDS)
        {
            InitializeComponent();
            _personajesJDS = personajesJDS;
            BindingContext = this;
        }


        private async void ConsultaBTN_Clicked(object sender, EventArgs e)
        {
            Loading.IsVisible = true;

            var data = await _personajesJDS.ObtenerPersonaje();
            listPersonajes.ItemsSource = data;
            Loading.IsVisible = false;
        }

        private void GuardarSQLite_Clicked(object sender, EventArgs e)
        {
            var id =_personajesJDS.ObtenerPersonaje().Id.ToString();
            App.personajesRepo.AddNewPerson(id);
        }
    }

}

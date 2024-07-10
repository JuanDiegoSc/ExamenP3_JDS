using ExamenP3_JDS.Models;

namespace ExamenP3_JDS.Views;

public partial class MostrarDatosSQLite : ContentPage
{
	public MostrarDatosSQLite()
	{
		InitializeComponent();
	}

    private void MostrarDatos_Clicked(object sender, EventArgs e)
    {
        List<PersonajesJDS> people = App.personajesRepo.GetAllPeople();
        peopleList.ItemsSource = people;
    }
}
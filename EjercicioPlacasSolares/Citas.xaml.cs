using PlacasSolares_ENT;

namespace EjercicioPlacasSolares;

public partial class Citas : ContentPage
{
	public Citas()
	{
		InitializeComponent();
        CitasListView.ItemsSource = GetCitas();

    }

    // M�todo que simula obtener citas desde una base de datos
    private List<Cita> GetCitas()
    {
        return new List<Cita>
            {
                new Cita { Nombre = "Juan P�rez", Direccion = "Av. Siempre Viva 123", Telefono = "123 45 67 89", FechaHora = DateTime.Now.AddHours(2) },
                new Cita { Nombre = "Mar�a Gonz�lez", Direccion = "Calle Ficticia 456", Telefono = "987 65 43 21", FechaHora = DateTime.Now.AddHours(3) },
                new Cita { Nombre = "Carlos Fern�ndez", Direccion = "Calle Luna 789", Telefono = "654 98 71 23", FechaHora = DateTime.Now.AddHours(4) }
            };
    }

    // Evento al seleccionar una cita
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            Cita selectedCita = (Cita)e.SelectedItem;
            // Navegar a la p�gina de detalles
            await Navigation.PushAsync(new CitaDetalle(selectedCita));
        }
    }
}
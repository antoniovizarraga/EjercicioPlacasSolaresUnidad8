using PlacasSolares_ENT;

namespace EjercicioPlacasSolares;

public partial class CitaDetalle : ContentPage
{
	public CitaDetalle(Cita cita)
	{
		InitializeComponent();
        BindingContext = cita;  // Vinculamos la cita seleccionada al BindingContext de la página



    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Informe enviado", "El informe se ha enviado correctamente.", "Aceptar");
    }
}
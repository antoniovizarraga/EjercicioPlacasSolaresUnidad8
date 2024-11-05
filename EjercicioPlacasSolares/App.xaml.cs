using System.Globalization;

namespace EjercicioPlacasSolares
{
    public partial class App : Application
    {
        public App()
        {
            CultureInfo.CurrentCulture = CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("es-ES");
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}

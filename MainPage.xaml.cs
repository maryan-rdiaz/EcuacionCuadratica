namespace EcuacionCuadratica
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void CalcularRaices_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(new CalcularRaices());
        }
        private void ObtenerEcuacion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ObtenerEcuacion());
        }
        private void AcercaDe_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AcercaDe());
        }
        private void Salir(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}

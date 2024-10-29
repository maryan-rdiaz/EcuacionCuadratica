namespace EcuacionCuadratica;

public partial class AcercaDe : ContentPage
{
	public AcercaDe()
	{
		InitializeComponent();
	}

    private async void OnSalirClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
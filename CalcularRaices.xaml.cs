namespace EcuacionCuadratica;

public partial class CalcularRaices : ContentPage
{
    public CalcularRaices()
    {
        InitializeComponent();
    }

    private async void OnCalcularClicked(object sender, EventArgs e) 
    {
        double a, b, c;
        if (double.TryParse(entryA.Text, out a) &&
            double.TryParse(entryB.Text, out b) &&
            double.TryParse(entryC.Text, out c))
        {
            double discriminante = (b * b) - (4 * a * c);

            if (discriminante >= 0)
            {
                double sqrtDiscriminante = Math.Sqrt(discriminante);
                double x1 = (-b + sqrtDiscriminante) / (2 * a);
                double x2 = (-b - sqrtDiscriminante) / (2 * a);

                labelX1.Text = $"X1 = {x1:F2}";
                labelX2.Text = $"X2 = {x2:F2}";
            }
            else
            {
                labelX1.Text = "Raíces complejas";
                labelX2.Text = "Raíces complejas";
            }
        }
        else
        {
            await DisplayAlert("Error", "Por favor ingresa valores numéricos válidos para a, b y c.", "OK");
        }
    }

    private async void OnSalirClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}

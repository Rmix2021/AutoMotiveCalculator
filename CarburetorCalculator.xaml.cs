namespace AutomotivePerformanceCalculator;

public partial class CarburetorCalculator : ContentPage
{
	public CarburetorCalculator()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        var engineDisplacement = double.Parse(EngineDisplacement.Text);
        var maxRPM = double.Parse(MaxRpm.Text);
        var carburetorSize = (maxRPM * engineDisplacement) / 3456;

        CarburetorSize.Text = carburetorSize.ToString("F2");


    }
}
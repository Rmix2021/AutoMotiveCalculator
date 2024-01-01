namespace AutomotivePerformanceCalculator;

public partial class FuelPumpCalculator : ContentPage
{
	public FuelPumpCalculator()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        var desiredHorsePower = double.Parse(DesiredHorsepower.Text);
        var baseFuelPressure = double.Parse(BaseFuelPressure.Text);
        var bsfc = double.Parse(BSFC.Text);
        var targetBoost = double.Parse(TargetBoost.Text);
        var totalFuelPressureRequired = baseFuelPressure + targetBoost + 10;
        var fuelWeight = double.Parse(FuelWeight.Text);
        var fuelPumpSizeLBSHr = desiredHorsePower * bsfc;

        var fuelPumpSizeGalhr = fuelPumpSizeLBSHr / fuelWeight;

        var fuelPumpSizeLPH = fuelPumpSizeGalhr / 3.78541;       
      
        


        FuelPumpSizeLBSHr.Text = fuelPumpSizeLBSHr.ToString("F2");
        FuelPumpSizeGalhr.Text = fuelPumpSizeGalhr.ToString("F2");
        FuelPumpSizeLMN.Text = fuelPumpSizeLPH.ToString("F2");

    }
}
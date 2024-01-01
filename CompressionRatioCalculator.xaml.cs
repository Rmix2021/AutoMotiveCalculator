namespace AutomotivePerformanceCalculator;

public partial class CompressionRatioCalculator : ContentPage
{
	public CompressionRatioCalculator()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        var cylinderBore = double.Parse(CylinderBore.Text);
        var engineStroke = double.Parse(EngineStroke.Text);
        var combustionChamberSize = double.Parse(CombustionChamberSize.Text);
        var pistonDish = double.Parse(PistonDish.Text);
        var deckClearance = double.Parse(DeckClearance.Text);
        var headGasketThickness = double.Parse(HeadGasketThickness.Text);
        var headGasketBore = double.Parse(HeadGasketBore.Text);

        //Math variables
        var sweptVolume = (((Math.Pow((cylinderBore / 2),2)) * 3.14) * engineStroke) * 16.387 ;

        var gasketVolume = ((Math.Pow((headGasketBore / 2),2) * 3.14) * headGasketThickness) * 16.387 ;

        var deckVolume = ((Math.Pow((cylinderBore / 2), 2) * 3.14) * deckClearance) * 16.387;

        var clearanceVolume = combustionChamberSize + pistonDish + gasketVolume + deckVolume;

        var compressionRatio = (sweptVolume + clearanceVolume) / clearanceVolume ;

        CompressionRatio.Text = compressionRatio.ToString("F2");
    }
}
namespace AutomotivePerformanceCalculator;

public partial class InjectorCalculator : ContentPage
{
	public InjectorCalculator()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        var desiredHorsePower = double.Parse(DesiredHorsepower.Text);
        var cylinderCount = double.Parse(CylinderCount.Text);
        var bsfc = double.Parse(BSFC.Text);
        var injectorSizeLBS = (desiredHorsePower * bsfc / cylinderCount) * 1.15;
        var injectorSizeCC = ((desiredHorsePower * bsfc /cylinderCount) * 10.23)*1.15;

        InjectorSizeCC.Text = injectorSizeCC.ToString("F2");
        InjectorSizeLBS.Text = injectorSizeLBS.ToString("F2");
       
        
    }
}
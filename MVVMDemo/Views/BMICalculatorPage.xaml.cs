using MVVMDemo.ViewModels;

namespace MVVMDemo.Views;

public partial class BMICalculatorPage : ContentPage
{
	public BMICalculatorPage()
	{
		InitializeComponent();
		this.BindingContext = new BMICalculatorPageViewModel();
	}
}
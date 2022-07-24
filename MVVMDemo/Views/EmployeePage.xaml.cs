using MVVMDemo.ViewModels;

namespace MVVMDemo.Views;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();
		this.BindingContext = new EmployeePageViewModel();
	}
}
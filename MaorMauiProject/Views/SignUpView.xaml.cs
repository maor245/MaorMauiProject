using MaorMauiProject.ViewModels;

namespace MaorMauiProject.Views;

public partial class SignUpView : ContentPage
{
	public SignUpView()
	{
		InitializeComponent();
		BindingContext = new SignUpViewModel();

	}
}
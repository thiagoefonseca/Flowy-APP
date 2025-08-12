using FlowyAPP.ViewModels;

namespace FlowyAPP.Views;

public partial class PerfilView : ContentPage
{
	public PerfilView()
	{
		InitializeComponent();
		BindingContext = new PerfilViewModel();
	}
}
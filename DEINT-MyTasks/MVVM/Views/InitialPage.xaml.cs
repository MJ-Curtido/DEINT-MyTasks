using DEINT_MyTasks.MVVM.ViewModels;

namespace DEINT_MyTasks.MVVM.Views;

public partial class InitialPage : ContentPage
{
	private MyTasksViewModel viewModel;

	public InitialPage()
	{
		InitializeComponent();

		viewModel = new MyTasksViewModel();

		BindingContext = viewModel;
	}

	private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		viewModel.completarCategorias();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FormPage());
	}
}
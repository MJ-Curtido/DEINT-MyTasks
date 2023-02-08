using DEINT_MyTasks.MVVM.ViewModels;

namespace DEINT_MyTasks.MVVM.Views;

public partial class FormPage : ContentPage
{
	public FormPage()
	{
		InitializeComponent();

		BindingContext = new MyTasksViewModel();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{

	}
}
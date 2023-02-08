using DEINT_MyTasks.MVVM.ViewModels;

namespace DEINT_MyTasks.MVVM.Views;

public partial class FormPage : ContentPage
{
	public FormPage()
	{
		InitializeComponent();

		BindingContext = new MyTasksViewModel();
	}
}
using DEINT_MyTasks.MVVM.ViewModels;

namespace DEINT_MyTasks.MVVM.Views;

public partial class InitialPage : ContentPage
{
	public InitialPage()
	{
		InitializeComponent();

		BindingContext = new MyTasksViewModel();
	}
}
using DEINT_MyTasks.MVVM.Views;

namespace DEINT_MyTasks;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new InitialPage();
	}
}

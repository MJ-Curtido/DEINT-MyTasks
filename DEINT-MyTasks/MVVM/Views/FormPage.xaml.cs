using DEINT_MyTasks.MVVM.Models;
using DEINT_MyTasks.MVVM.ViewModels;
using Task = DEINT_MyTasks.MVVM.Models.Task;

namespace DEINT_MyTasks.MVVM.Views;

public partial class FormPage : ContentPage
{
	private MyTasksViewModel modelView;
	private int idCategoriaSeleccionada;

	public FormPage(MyTasksViewModel modelView)
	{
		InitializeComponent();

		this.modelView = modelView;
		idCategoriaSeleccionada = -1;

		BindingContext = modelView;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if (!txtTareaCategoria.Text.ToString().Equals(""))
		{
			if (idCategoriaSeleccionada != -1)
			{
				modelView.anyadirTarea(new Task(txtTareaCategoria.Text.ToString(), idCategoriaSeleccionada));
				modelView.completarCategorias();
				Navigation.PopAsync();
			}
			else
			{
				mostrarAlertaRbtnNull();

			}
		}
		else
		{
			mostrarAlertaCampoVacio();
		}
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		if (!txtTareaCategoria.Text.ToString().Equals(""))
		{
			modelView.anyadirCategoria(new Category(txtTareaCategoria.Text.ToString()));
			modelView.completarCategorias();
			Navigation.PopAsync();
		}
		else
		{
			mostrarAlertaCampoVacio();
		}
	}

	private async void mostrarAlertaCampoVacio()
	{
		await DisplayAlert("Error", "El campo de nombre de tarea o categoría no puede estar vacío.", "Ok");
	}

	private async void mostrarAlertaRbtnNull()
	{
		await DisplayAlert("Error", "Tienes que elegir una categoría.", "Ok");
	}

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		RadioButton rbtn = (RadioButton)sender;

		idCategoriaSeleccionada = (int)(rbtn.Value);
	}
}
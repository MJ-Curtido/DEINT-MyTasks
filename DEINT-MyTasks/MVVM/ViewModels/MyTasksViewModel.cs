using DEINT_MyTasks.MVVM.Models;
using PropertyChanged;
using System.Collections.ObjectModel;
using Task = DEINT_MyTasks.MVVM.Models.Task;

namespace DEINT_MyTasks.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MyTasksViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }

        public MyTasksViewModel()
        {
            Categories = new ObservableCollection<Category>()
            {
                new Category("Tareas de casa"),
                new Category("Deporte"),
                new Category("Comida")
            };

            Tasks = new ObservableCollection<Task>()
            {
                new Task("Hacer pollo al curry.", 2),
                new Task("Saltar la comba.", 1),
                new Task("Poner la lavadora.", 0),
                new Task("Limpiar el cuarto de baño.", 0),
                new Task("Hacer ciclismo.", 1),
                new Task("Hacer tortitas.", 2),
                new Task("hacer lentejas.", 2),
                new Task("Hacer skate.", 1),
                new Task("Limpiar el patio.", 0)
            };

            completarCategorias();
            }

        public void completarCategorias()
        {
            double contTasks;
            double contTasksSinCompletar;

            for (int i = 0; i < Categories.Count; i++)
            {
                contTasks = 0.0;
                contTasksSinCompletar = 0.0;

                for (int j = 0; j < Tasks.Count; j++)
                {
                    if (Categories[i].Id == Tasks[j].IdCategory)
                    {
                        contTasks++;
                        if (!Tasks[j].Completed)
                        {
                            contTasksSinCompletar++;
                        }
                    }
                }

                Categories[i].NumTasksSinCompletar = contTasksSinCompletar;
                Categories[i].PorcentajeCompletado = (contTasks - contTasksSinCompletar) / contTasks;
            }
        }
    }
}

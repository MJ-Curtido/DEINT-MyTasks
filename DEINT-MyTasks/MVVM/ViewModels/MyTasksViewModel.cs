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

        public void anyadirCategoria(Category c)
        {
            Categories.Add(c);
        }

        public void anyadirTarea(Task t)
        {
            Tasks.Add(t);
        }

        public void completarCategorias()
        {
            double contTasks;
            double contTasksSinCompletar;

            foreach (Category c in Categories)
            {
                contTasks = Tasks.Where(t => t.IdCategory == c.Id).ToList().Count();
                contTasksSinCompletar = Tasks.Where(t => t.IdCategory == c.Id && !t.Completed).ToList().Count();

                c.NumTasksSinCompletar = contTasksSinCompletar;
                c.PorcentajeCompletado = (contTasks - contTasksSinCompletar) / contTasks;
            }
        }
    }
}

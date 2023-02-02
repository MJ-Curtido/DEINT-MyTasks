using DEINT_MyTasks.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = DEINT_MyTasks.MVVM.Models.Task;

namespace DEINT_MyTasks.MVVM.ViewModels
{
    public class MyTasksViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Task> Tasks { get; set; }
    }
}

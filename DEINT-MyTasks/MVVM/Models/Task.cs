using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_MyTasks.MVVM.Models
{
    public class Task
    {
        public String TxtTask { get; set; }
        public String IdCategory { get; set; }
        public Boolean Completed { get; set; }

        public Task(String TxtTask, String IdCategory)
        {
            this.TxtTask = TxtTask;
            this.IdCategory = IdCategory;
            this.Completed = false;
        }
    }
}

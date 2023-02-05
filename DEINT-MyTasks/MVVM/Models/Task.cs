using PropertyChanged;

namespace DEINT_MyTasks.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]

    public class Task
    {
        public String TxtTask { get; set; }
        public int IdCategory { get; set; }
        public Boolean Completed { get; set; }

        public Task(String TxtTask, int IdCategory)
        {
            this.TxtTask = TxtTask;
            this.IdCategory = IdCategory;
            this.Completed = false;
        }
    }
}

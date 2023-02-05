using PropertyChanged;

namespace DEINT_MyTasks.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]

    public class Category
    {
        public static int IdTemp { get; set; } = 0;
        public int Id { get; set; }
        public String TxtCategory { get; set; }
        public double NumTasksSinCompletar { get; set; } = 0.0;
        public double PorcentajeCompletado { get; set; } = 0.0;

        public Category(String TxtCategory)
        {
            this.Id = IdTemp;
            this.TxtCategory = TxtCategory;

            IdTemp++;
        }
    }
}

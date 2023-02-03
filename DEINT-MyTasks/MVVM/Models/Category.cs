namespace DEINT_MyTasks.MVVM.Models
{
    public class Category
    {
        public static int IdTemp { get; set; } = 0;
        public int Id { get; set; }
        public String TxtCategory { get; set; }

        public Category(String TxtCategory)
        {
            this.Id = IdTemp;
            this.TxtCategory = TxtCategory;

            IdTemp++;
        }
    }
}

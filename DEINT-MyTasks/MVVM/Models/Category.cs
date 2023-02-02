using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_MyTasks.MVVM.Models
{
    public class Category
    {
        public String Id { get; set; }
        public String TxtCategory { get; set; }

        public Category(String TxtCategory)
        {
            this.Id = Guid.NewGuid().ToString();
            this.TxtCategory = TxtCategory;
        }
    }
}

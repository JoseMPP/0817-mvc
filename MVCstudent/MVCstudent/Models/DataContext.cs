using System.Data.Entity;

namespace MVCstudent.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection") {

        }
    }
}
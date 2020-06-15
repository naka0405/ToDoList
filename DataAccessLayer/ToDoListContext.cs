using DataAccessLayer.Models;
using System.Data.Entity;
using Task = DataAccessLayer.Models.Task;

namespace DataAccessLayer
{
   public class ToDoListContext:DbContext
    {
        public ToDoListContext():base("Connect")
        {
            Database.SetInitializer(new Initializer());
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DoneTask> DoneTasks { get; set; }

    }
}

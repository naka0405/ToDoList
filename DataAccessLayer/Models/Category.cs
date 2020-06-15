using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Category
    {
        public Category()
        {
            TaskProp = new List<Task>();
        }
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public List<Task> TaskProp { get; set; }

    }
}

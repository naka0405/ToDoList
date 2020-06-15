using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class DoneTask
    {
        public DoneTask()
        {
            CategoryProperty = new List<Category>();
        }
        public int ID { get; set; }
        public string DoneTaskName { get; set; }
        public string FinishDate { get; set; }
       // public Category CategoryId { get; set; }
        public List<Category> CategoryProperty { get; set; }

    }
}

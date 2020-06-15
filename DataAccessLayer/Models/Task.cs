using System.Collections.Generic;


namespace DataAccessLayer.Models
{
    public class Task
    {
        public Task()
        {
            CatigoryProp = new List<Category>();
        }
        public int ID { get; set; }
        public string TaskName { get; set; }
        public string StartDate { get; set; }
        public bool StatusDone { get; set; }
        public List<Category> CatigoryProp{ get; set; }
    }
}

using System.Collections.Generic;

namespace BisnessLogic.ModelsBL
{
        public  class TaskBL
    {
        public TaskBL()
        {
            CatigoryProp = new List<CategoryBL>();
        }
        public int ID { get; set; }
        public string TaskName { get; set; }
        public string StartDate { get; set; }
        public bool DoneStatus { get; set; }
        public List<CategoryBL> CatigoryProp { get; set; }
    }
}

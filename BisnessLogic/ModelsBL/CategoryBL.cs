using System.Collections.Generic;


namespace BisnessLogic.ModelsBL
{
    public class CategoryBL
    {
        public CategoryBL()
        {
            TaskProp = new List<TaskBL>();
        }
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public List<TaskBL> TaskProp { get; set; }
    }
}
